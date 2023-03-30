using System.Text;

namespace HomeWork07;


public class Screen
{
    protected View view;
    protected string data;
    protected Menu menu;
    protected string bar;
    public Screen(View view, string data, Menu menu)
    {
        this.view = view;
        this.data = data;
        this.menu = menu;
        this.bar = "";
    }

    public Screen(View view, string data) :
        this(view, data, new Menu())
    {
    }

    public Screen(View view, Menu menu) :
        this(view, "", menu)
    {
    }

    public Screen(View view) :
        this(view, "")
    {
    }

    public string getScreen()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(data);
        sb.Append(menu);
        sb.Append(bar);
        return sb.ToString();
    }

    public void setMenu(Menu menu)
    {
        this.menu = menu;
        show();
    }

    public void setData(string data)
    {
        this.data = data;
        show();
    }

    public void setBar(string bar)
    {
        this.bar = bar;
        show();
    }

    public Menu getMenu()
    {
        return menu;
    }

    public void show()
    {   
        view.clear();
        view.print(getScreen());
    }

    public View getView()
    {
        return this.view;
    }

    public void setScreen(string data, Menu menu, string bar)
    {
        this.data = data;
        this.menu = menu;
        this.bar = bar;
        show();
    }
}