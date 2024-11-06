using System.ComponentModel;
using System.Data.Entity;

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
    }
}
