﻿using System.Threading;
using UnityEngine;
using UnityEngine.UI;

namespace ET.Client
{
	[EntitySystemOf(typeof(UILoginComponent))]
	[FriendOf(typeof(UILoginComponent))]
	public static partial class UILoginComponentSystem
	{
		[EntitySystem]
		private static void Awake(this UILoginComponent self)
		{
			ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
			self.loginBtn = rc.Get<GameObject>("LoginBtn");
			self.account = rc.Get<GameObject>("Account");
			self.password = rc.Get<GameObject>("Password");
			self.loginBtn.GetComponent<Button>().onClick.AddListener(()=> { self.OnLogin(); });
		}

		
		public static void OnLogin(this UILoginComponent self)
		{
			Log.Debug($"OnLogin");
			LoginHelper.Login(
				self.Root(), 
				self.account.GetComponent<InputField>().text, 
				self.password.GetComponent<InputField>().text).Coroutine();
		}
	}
}
