namespace ET.Client;
[EntitySystemOf(typeof(Robot))]
public static partial class RobotSystem
{
    [EntitySystem]
    private static void Awake(this ET.Client.Robot self)
    {
        Log.Debug("RobotSystem.Awake");

    }
    [EntitySystem]
    private static void Destroy(this ET.Client.Robot self)
    {
        Log.Debug("RobotSystem.Destroy");

    }
    [EntitySystem]
    private static void Update(this ET.Client.Robot self)
    {
     //   Log.Debug("RobotSystem.Update");

    }
    [EntitySystem]
    private static void LateUpdate(this ET.Client.Robot self)
    {
    //    Log.Debug("RobotSystem.LateUpdate");

    }
}