namespace ET.Client;
[EntitySystemOf(typeof(DisplayComponent))]
public static partial class DisplayComponentSystem
{
    [EntitySystem]
    private static void Awake(this ET.Client.DisplayComponent self)
    {
        Log.Debug("DisplayComponentSystem.Awake");

    }
}