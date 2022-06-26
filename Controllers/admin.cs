using blogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace blogApp.Controllers
{
    public class admin : Controller
    {
        public readonly BlogContext _context;
        public admin(BlogContext context) { _context = context; }

        public IActionResult Index()
        {

            return View();
        }
        public IActionResult CreateBlog(Blog blog)
        {
            _context.Blogs.Add(blog);
            return View();
        }
    }
}
