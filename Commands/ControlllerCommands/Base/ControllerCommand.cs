namespace HomeWork07;

public abstract class ControllerCommand : BaseCommand
{
    protected Controller controller;

    public ControllerCommand(Controller controller) {
        this.controller = controller;
    }

}