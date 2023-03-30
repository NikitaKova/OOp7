using HomeWork07;

internal class Program
{
    private static void Main(string[] args)
    {
        Phonebook phonebook = new Phonebook();
        // phonebook.addContact(new Contact("Карпенко","+375 29 5518500"));
        View view = new View();
        Screen screen = new Screen(view,phonebook.ToString());
        Controller ctrl = new Controller(screen, phonebook);
        ctrl.run();
    }
}