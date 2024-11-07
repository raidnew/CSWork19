using CSWork19.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSWork19.Controllers
{
    public class PhoneBookController : Controller
    {
        private PhoneBookContext _phoneBookContext;

        public PhoneBookController()
        {
            _phoneBookContext = new PhoneBookContext();
        }

        public IActionResult ContactsList()
        {
            ViewBag.contacts = _phoneBookContext.GetItemSourceContacts();
            return View();
        }

        public IActionResult ContactsInfo(int id)
        {
            ViewBag.contact = _phoneBookContext.GetContactByID(id);
            return View();
        }
    }
}
