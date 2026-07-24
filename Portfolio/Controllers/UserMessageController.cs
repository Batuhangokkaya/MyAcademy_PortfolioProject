using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class UserMessageController : Controller
    {
        private readonly AppDbContext _context;

        public UserMessageController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var projects = _context.UserMessages.ToList();
            ViewBag.UserMessageCount = _context.UserMessages.Count();
            return View(projects);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserMessage userMessage)
        {
            _context.UserMessages.Add(userMessage);
            _context.SaveChanges();

            return RedirectToAction("Index", "UserMessage");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = _context.UserMessages.Find(id);
            return View(value);
        }

        [HttpPost]

        public IActionResult Update(UserMessage userMessage)
        {
            _context.UserMessages.Update(userMessage);
            _context.SaveChanges();
            return RedirectToAction("Index", "UserMessage");
        }

        public IActionResult Delete(int id)
        {
            var value = _context.UserMessages.Find(id);
            _context.UserMessages.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index", "UserMessage");
        }

        public IActionResult IsStatus(int id)
        {
            var userMessage = _context.UserMessages.Find(id);

            if (userMessage != null)
            {
                userMessage.IsRead = !userMessage.IsRead;
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "UserMessage");
        }
    }
}