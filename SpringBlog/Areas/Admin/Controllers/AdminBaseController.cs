using SpringBlog.Models;
using System.Web.Mvc;

namespace SpringBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminBaseController : Controller
    {
        protected ApplicationDbContext db = new ApplicationDbContext();

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}