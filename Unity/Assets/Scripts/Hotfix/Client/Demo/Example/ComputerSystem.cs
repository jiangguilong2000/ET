namespace ET.Client;

[EntitySystemOf(typeof(Computer))]
public static partial class ComputerSystem
{
    [EntitySystem]
    private static void Awake(this ET.Client.Computer self)
    {
        Log.Debug("ComputerSystem.Awake");

    }
    [EntitySystem]
    private static void Update(this ET.Client.Computer self)
    {

        Log.Debug("ComputerSystem.Update");


    }
    [EntitySystem]
    private static void Destroy(this ET.Client.Computer self)
    {
        Log.Debug("ComputerSystem.Destroy");

    }


    public static void Open(this Computer self)
    {

        Log.Debug("ComputerSystem.Open");
    }
    [EntitySystem]
    private static void LateUpdate(this ET.Client.Computer self)
    {
        Log.Debug("ComputerSystem.LateUpdate");

    }
}