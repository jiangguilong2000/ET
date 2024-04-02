using System.Threading;

namespace ET.Client
{
	[Event(SceneType.Demo)]
	public class AppStartInitFinish_CreateLoginUI: AEvent<Scene, AppStartInitFinish>
	{
		protected override async ETTask Run(Scene root, AppStartInitFinish args)
		{
			
			Robot robot=root.GetComponent<RobotComponent>().AddChild<Robot>();
			BrainComponent brainComponent=robot.AddComponent<BrainComponent>();
			brainComponent.ChangeStatus(StatusEnum.Pending);
			
			
			Phone phone=root.GetComponent<PhoneComponent>().AddChild<Phone>();
			phone.AddComponent<DisplayComponent>();
			phone.Open();

			// //await TestAsync(root);
			// TestAsync(root).Coroutine();
			// await TestAsync2(root);
			
		//	phone.Open();
		
			// phone.Open();
			// phone.Open();
		// phone.	
			
			await UIHelper.Create(root, UIType.UILogin, UILayer.Mid);
		}
		//
		// public async ETTask TestAsync(Scene root)
		// {
		// 	Log.Debug("testAsync start");
		// 	await root.GetComponent<TimerComponent>().WaitAsync(3000);
		// 	Log.Debug("testAsync end");
		//
		// }
		//
		//
		// public async ETTask<int> TestAsync2(Scene root)
		// {
		// 	Log.Debug("testAsync2 start");
		// 	await root.GetComponent<TimerComponent>().WaitAsync(3000);
		// 	Log.Debug("testAsync2 end");
		// 	return 10;
		// }

	}
}
