namespace ET.Client;
[EntitySystemOf(typeof(Phone))]
public static partial class PhoneSystem
{
   
    public static void Open(this Phone self)
    {
        Log.Debug("PhoneComponentSystem.Open");
    }
    [EntitySystem]
    private static void Awake(this ET.Client.Phone self)
    {

    }
    [EntitySystem]
    private static void Destroy(this ET.Client.Phone self)
    {

    }
    [EntitySystem]
    private static void Update(this ET.Client.Phone self)
    {

    }
    [EntitySystem]
    private static void LateUpdate(this ET.Client.Phone self)
    {

    }

}