
using Microsoft.AspNetCore.Mvc;
using basicMeetingApp.Models;

namespace basicMeetingApp.Controllers
{

    public class MeetingController : Controller
    {


        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            Repository.AddResponse(model);
            ViewBag.UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();
            return View("Thanks",model);
        }
        public IActionResult List()
        {
            return View(Repository.Users);
        }

        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }


    }
}