using SpringBlog.Helpers;
using System.Web.Mvc;

namespace SpringBlog.Areas.Admin.Controllers
{
    public class SlugController : Controller
    {
        [HttpPost]
        public string ConvertToSlug(string title)
        {
            return UrlService.URLFriendly(title);
        }
    }
}