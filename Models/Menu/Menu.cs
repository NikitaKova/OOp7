using System.Text;

namespace HomeWork07;

public class Menu {
    private List<PunktMenu> puncts;

    public Menu() {
        this.puncts = new List<PunktMenu>();
    }

    public void addPunkt(PunktMenu punktMenu) {
        puncts.Add(punktMenu);
    }

    public void clear() {
        this.puncts = new List<PunktMenu>();
        
    }

    public PunktMenu getPunkt(int number){
        foreach (PunktMenu item in puncts)
        {   
            if (item.number == number) {
                return item;
            }        
        }
        return null;
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();
        if (puncts.Count>0)
        sb.Append("Меню:\n");
        foreach (PunktMenu pm in puncts) {
            sb.Append(string.Format($"{pm.ToString()} \n"));
        }
        return sb.ToString();
    }
}