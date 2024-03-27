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
		
			
		//	phone.Open();
		
			// phone.Open();
			// phone.Open();
		// phone.	
			
			await UIHelper.Create(root, UIType.UILogin, UILayer.Mid);
		}

		
	}
}
