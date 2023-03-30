namespace HomeWork07;

public class SaveToFilePhonebookCommand:ControllerCommand
{

    public SaveToFilePhonebookCommand(Controller controller):
    base(controller)
    {
    }
    public override void execute() {
        Screen screen = controller.getScreen();
        View view = screen.getView();
        Menu menu = screen.getMenu();
        Phonebook phonebook = controller.getPhonebook();
        screen.setMenu(new Menu());
        screen.setBar("Введите имя файла: ");
        string fileName = view.getString()+".txt";

        StreamWriter? writer = null;
        try
        {
            writer = new StreamWriter(fileName);
            foreach (Contact contact in phonebook.getContacts()) {
                writer.Write(contact.getLastname()+"\n");
                writer.Write(contact.getFirstname()+"\n");
                writer.Write(contact.getMiddlename()+"\n");
                writer.Write(contact.getTelnumber()+"\n");
                writer.Write(contact.getEmailaddr()+"\n");
            }
            writer.Flush();
            screen.setBar("Cправочник успешно cохранен");
        }
        catch
        {
            screen.setBar("Ошибка файла, нажмите любую клавишу");
            Console.ReadKey();

        }
        finally
        {
            writer?.Close();
        }
        screen.setScreen(controller.getPhonebook().ToString(), menu, "");
    }

}