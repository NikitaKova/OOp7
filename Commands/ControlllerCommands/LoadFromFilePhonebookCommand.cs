namespace HomeWork07;


public class LoadFromFilePhonebookCommand : ControllerCommand
{

    public LoadFromFilePhonebookCommand(Controller controller) :
        base(controller)
    {
    }


    public override void execute()
    {
        Screen screen = controller.getScreen();
        View view = screen.getView();
        Menu menu = screen.getMenu();
        screen.setMenu(new Menu());
        screen.setBar("Введите имя файла: ");
        string fileName = view.getString() + ".txt";

        StreamReader? reader = null;
        try
        {
            reader = new StreamReader(fileName);
            controller.getPhonebook().clear();
            String lastname = reader.ReadLine();
            while (lastname != null)
            {
                String firstname = reader.ReadLine();
                String middlename = reader.ReadLine();
                String telnumber = reader.ReadLine();
                String emailaddr = reader.ReadLine();
                controller.getPhonebook()
                        .addContact(new Contact(lastname, firstname, middlename, telnumber, emailaddr));

                lastname = reader.ReadLine();
            }
            screen.setBar("Cправочник успешно загружен");
        }
        catch
        {
            screen.setBar("Ошибка файла, нажмите любую клавишу");
            Console.ReadKey();

        }
        finally
        {
            reader?.Close();
        }

        screen.setScreen(controller.getPhonebook().ToString(), menu, "");
    }

}