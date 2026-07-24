using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly AppDbContext _context;

        public TestimonialController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {

            var firstName = string.Concat(
                testimonial.FirstName
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => char.ToUpper(x[0]))
            );

            var lastName = string.Concat(
                testimonial.LastName
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => char.ToUpper(x[0]))
            );

            testimonial.Initials = firstName + lastName;

            _context.Testimonials.Add(testimonial);
            _context.SaveChanges();
            return RedirectToAction("Index", "Default");
        }
    }
}