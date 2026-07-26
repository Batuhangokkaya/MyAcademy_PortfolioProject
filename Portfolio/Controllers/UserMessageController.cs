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

        public IActionResult Index(bool? isRead)
        {
            List<UserMessage> values;

            if (isRead == true)
            {
                values = _context.UserMessages
                    .Where(x => x.IsRead)
                    .ToList();
            }
            else if (isRead == false)
            {
                values = _context.UserMessages
                    .Where(x => !x.IsRead)
                    .ToList();
            }
            else
            {
                values = _context.UserMessages.ToList();
            }

            ViewBag.UserMessageCount   = values.Count();
            ViewBag.SelectedStatus     = isRead;
            ViewBag.TotalUnreadMessage = values.Where(x => !x.IsRead).Count();
            ViewBag.TotalReadMessage   = values.Where(x => x.IsRead).Count();

            return View(values);
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

        [HttpPost]
        public IActionResult IsStatus(int id, bool isRead)
        {
            var userMessage = _context.UserMessages.Find(id);

            if (userMessage == null)
            {
                return NotFound();
            }

            userMessage.IsRead = isRead;
            _context.SaveChanges();

            return Json(new
            {
                success = true,
                isRead  = userMessage.IsRead
            });
        }
    }
}