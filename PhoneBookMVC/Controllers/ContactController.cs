using Microsoft.AspNetCore.Mvc;
using PhoneBookLib;

namespace PhoneBookMVC.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactDataAccess _dal;
        public ContactController(IContactDataAccess dal)
        {
            _dal = dal;
        } 
        [HttpGet]
        public IActionResult Index()
        {
            var con = _dal.GetContactById(1);
            return View(con);
        }
        public IActionResult Home()
        {
            var contacts = _dal.GetContacts();
            return View(contacts);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            _dal.AddContact(contact);
            return RedirectToAction("Home");
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var con = _dal.GetContactById(Id);
            return View(con);
        }
        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            _dal.UpdateContacts(contact);
            return RedirectToAction("Home");
        }
        public IActionResult Delete(int id)
        {
            _dal.DeleteContact(id);
            return RedirectToAction("Home");
        }
        [HttpGet]
        public IActionResult Details(int Id)
        {
            var con = _dal.GetContactById(Id);
            return View(con);
        }
    }
}
