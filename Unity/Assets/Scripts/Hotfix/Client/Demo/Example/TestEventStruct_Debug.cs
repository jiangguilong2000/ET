namespace ET.Client;

    [Event(SceneType.Demo)]
    public class TestEventStruct_Debug:AEvent<Scene, TestEventStruct>
    {
        protected override async ETTask Run(Scene scene, TestEventStruct a)
        {
            Log.Debug(a.testValue.ToString());
            await  ETTask.CompletedTask;
        }
    }


