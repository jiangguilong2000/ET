namespace ET.Client;

[EntitySystemOf(typeof(BrainComponent))]
public static partial class BrainSystem
{
    [EntitySystem]
    private static void Awake(this ET.Client.BrainComponent self)
    {
        Log.Debug("BrainSystem.Awake");

    }
    [EntitySystem]
    private static void Destroy(this ET.Client.BrainComponent self)
    {
        Log.Debug("BrainSystem.Destroy");

    }
    [EntitySystem]
    private static void Update(this ET.Client.BrainComponent self)
    {
      //  Log.Debug("BrainSystem.Update");

            
    }
    [EntitySystem]
    private static void LateUpdate(this ET.Client.BrainComponent self)
    {
     //   Log.Debug("BrainSystem.LateUpdate");

    }

    public static void ChangeStatus(this BrainComponent self, StatusEnum status)
    {
        Log.Debug($"BrainSystem.ChangeStatus: {status}");
        self.status = status;
        
    }
}