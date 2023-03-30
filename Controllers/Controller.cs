namespace HomeWork07;

public class Controller {
    protected bool exitApp;
    protected Screen screen;
    protected Phonebook phonebook;
    protected View view;

    public Controller(Screen screen, Phonebook phonebook) {
        this.screen = screen;
        this.view = screen.getView();
        this.phonebook = phonebook;
        this.exitApp = false;
    }

    public void run() {

        new MakeMainMenuCommand(this).execute();
        while (!exitApp) {
            screen.show();
            int numPunkt = view.getPositiveInt();
            PunktMenu pm = screen.getMenu().getPunkt(numPunkt);
            if (pm == null) {
                screen.setBar("Неправильный выбор");
            } else {
                pm.run();
            }
        }

    }

    public Screen getScreen() {
        return this.screen;
    }

    public Phonebook getPhonebook() {
        return this.phonebook;
    }

    public void setExitApp() {
        this.exitApp = true;
    }

}