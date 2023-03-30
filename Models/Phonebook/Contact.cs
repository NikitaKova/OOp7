public class Contact
{
    private string lastname;
    private string firstname;
    private string middlename;
    private string telnumber;
    private string emailaddr;

    public Contact(string lastname, string firstname, string middlename, string telnumber, string emailaddr)
    {
        this.lastname = lastname;
        this.firstname = firstname;
        this.telnumber = telnumber;
        this.middlename = middlename;
        this.emailaddr = emailaddr;
    }

    public Contact(string lastname, string firstname, string telnumber) :
        this(lastname, firstname, "", telnumber, "")
    {
    }

    public Contact(string lastname, string telnumber) :
        this(lastname, "", "", telnumber, "")
    {

    }

    public string getLastname()
    {
        return lastname;
    }

    public void setLastname(string lastname)
    {
        this.lastname = lastname;
    }

    public string getFirstname()
    {
        return firstname;
    }

    public void setFirstname(string firstname)
    {
        this.firstname = firstname;
    }

    public string getMiddlename()
    {
        return middlename;
    }

    public void setMiddlename(string middlename)
    {
        this.middlename = middlename;
    }

    public string getTelnumber()
    {
        return telnumber;
    }

    public void setTelnumber(string telnumber)
    {
        this.telnumber = telnumber;
    }

    public string getEmailaddr()
    {
        return emailaddr;
    }

    public void setEmailaddr(string emailaddr)
    {
        this.emailaddr = emailaddr;
    }


    public override string? ToString()
    {
        return lastname + " " + firstname + " " + middlename + " Tel.:" + telnumber +
                                  " e-mail:" + emailaddr;
    }
}