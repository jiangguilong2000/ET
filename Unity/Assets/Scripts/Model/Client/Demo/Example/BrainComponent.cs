namespace ET.Client;

[ComponentOf(typeof(Robot))]
public class BrainComponent:Entity,IAwake,IDestroy,IUpdate,ILateUpdate
{
    public StatusEnum status { get; set; }

}