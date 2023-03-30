namespace HomeWork07;
using System.Text;


public class Phonebook
{
    private List<Contact>? contacts;
    private int count;

    public Phonebook()
    {
        this.contacts = new List<Contact>();
        this.count = 0;
    }

    public void addContact(Contact contact)
    {
        contacts.Add(contact);
    }
    public List<Contact> getContacts()
    {
        return contacts;
    }

    public bool removeContact(Contact contact)
    {
        return contacts.Remove(contact);
    }
    public int getCount()
    {
        return count;
    }
    public void clear() {
        this.contacts =  new List<Contact>();
        
    }

    public override string? ToString()
    {
        StringBuilder sb = new StringBuilder();
        foreach (Contact record in contacts)
        {
            sb.AppendFormat("{0}\n", record.ToString());
        }
        return sb.ToString();
    }
}