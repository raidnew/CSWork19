using CSWork19.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSWork19.Controllers
{
    public class PhoneBookController : Controller
    {
        private PhoneBookContext _phoneBookContext;

        public IActionResult ContactsList()
        {
            _phoneBookContext = new PhoneBookContext();
            _phoneBookContext.GetItemSourceContacts();
            return View();
        }

        public IActionResult ContactsInfo()
        {
            return View();
        }
    }
}
