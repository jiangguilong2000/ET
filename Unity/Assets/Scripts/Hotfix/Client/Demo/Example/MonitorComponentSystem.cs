namespace ET.Client;

[EntitySystemOf(typeof(MonitorComponent))]
public static partial class MonitorComponentSystem
{
    [EntitySystem]
    private static void Awake(this ET.Client.MonitorComponent self, int args2)
    {
        Log.Debug("MonitorComponentSystem.Awake");
        self.Brightness = args2;

    }
    [EntitySystem]
    private static void Destroy(this ET.Client.MonitorComponent self)
    {

        Log.Debug("MonitorComponentSystem.Destroy");
    }
    public static void ChangeBrightness(this MonitorComponent self, int args2)
    {
        self.Brightness = args2;
        Log.Debug($"add brightness: {self.Brightness}");
    }
}