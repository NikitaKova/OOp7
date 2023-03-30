namespace HomeWork07;

public class MakeMainMenuCommand : ControllerCommand
{
    public MakeMainMenuCommand(Controller controller) :
        base(controller)
    {

    }

    
    public override void execute()
    {
        Menu menu = new Menu();
        menu.addPunkt(new PunktMenu(1, "Загрузить справочник из файла", new LoadFromFilePhonebookCommand(controller)));
        menu.addPunkt(new PunktMenu(2, "Сохранить справочник в файл", new SaveToFilePhonebookCommand(controller)));
        menu.addPunkt(new PunktMenu(0, "Выход", new ExitAppCommand(controller)));
        controller.getScreen().setMenu(menu);
    }

}