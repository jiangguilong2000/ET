﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ET.Client
{
    [MessageHandler(SceneType.NetClient)]
    public class Main2NetClient_LoginHandler: MessageHandler<Scene, Main2NetClient_Login, NetClient2Main_Login>
    {
        protected override async ETTask Run(Scene root, Main2NetClient_Login request, NetClient2Main_Login response)
        {
            string account = request.Account;
            string password = request.Password;
            
            root.RemoveComponent<RouterAddressComponent>();
            //连上routermanager
            RouterAddressComponent routerAddressComponent =
                    root.AddComponent<RouterAddressComponent, string, int>(ConstValue.RouterHttpHost, ConstValue.RouterHttpPort);
            //获取router的地址和realm的地址
            await routerAddressComponent.Init();
            //看不懂，为什么是UDP
            //创建和router的连接,KCP里包含TCP,和UDP,
            root.AddComponent<NetComponent, AddressFamily, NetworkProtocol>(routerAddressComponent.RouterManagerIPAddress.AddressFamily, NetworkProtocol.UDP);
            root.GetComponent<FiberParentComponent>().ParentFiberId = request.OwnerFiberId;

            NetComponent netComponent = root.GetComponent<NetComponent>();
            
            IPEndPoint realmAddress = routerAddressComponent.GetRealmAddress(account);
       
            R2C_Login r2CLogin;
            // 创建一个router Session,包括连接，并且保存到SessionComponent中
            using (Session session = await netComponent.CreateRouterSession(realmAddress, account, password))
            {
                //这个消息通过router 走向realm server
                r2CLogin = (R2C_Login)await session.Call(new C2R_Login() { Account = account, Password = password });
            }
            if (r2CLogin.Error!= ErrorCode.ERR_Success)
            {
                response.Error=r2CLogin.Error;
                return;
            }

            // 创建一个gate Session,还是通过router去连接gate
            Session gateSession = await netComponent.CreateRouterSession(NetworkHelper.ToIPEndPoint(r2CLogin.Address), account, password);
            gateSession.AddComponent<ClientSessionErrorComponent>();
            root.AddComponent<SessionComponent>().Session = gateSession;
            //发起登录请求
            G2C_LoginGate g2CLoginGate = (G2C_LoginGate)await gateSession.Call(new C2G_LoginGate() { Key = r2CLogin.Key, GateId = r2CLogin.GateId });

            Log.Debug("登陆gate成功!");

            response.PlayerId = g2CLoginGate.PlayerId;
        }
    }
}