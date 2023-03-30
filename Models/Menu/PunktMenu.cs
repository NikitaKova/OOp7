public class PunktMenu {
    public int number;
    private string text;
    private Command command;
    public PunktMenu(int number, string text, Command command) {
        this.number = number;
        this.text = text;
        this.command = command;
    }
    
    public override string ToString() {
        return string.Format($"{this.number}. {this.text}");
    }
    public void run(){
        this.command.execute();
    }
    public Command getCommand(){
        return this.command;
    }
    
}