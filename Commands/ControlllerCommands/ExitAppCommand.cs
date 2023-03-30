namespace HomeWork07;

public class ExitAppCommand : ControllerCommand
{

    public ExitAppCommand(Controller controller) : 
    base(controller)
    {
    }

    public override void execute()
    {
        controller.getScreen().setBar("До свидания.");
        controller.setExitApp();
    }
}