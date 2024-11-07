using System.ComponentModel;
using System.Data.Entity;
using System.Linq;

namespace CSWork19.Models
{
    public class PhoneBookContext : DbContext
    {
        public PhoneBookContext() : base("DBPhoneBookContext") { }

        public DbSet<Contact> Contacts{ get; set; }

        public BindingList<Contact> GetItemSourceContacts()
        {
            Contacts.Load();
            return Contacts.Local.ToBindingList();
        }

        public Contact GetContactByID(int id)
        {
            Contacts.Load();
            return Contacts.Single(c => c.Id == id);
        }

    }
}
