using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using basicMeetingApp.Models;

namespace basicMeetingApp.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        int saat = DateTime.Now.Hour;
        ViewBag.Selamlama = saat > 12 ? "İyi Günler" : "Günaydın";
        int UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();

        var meetingInfo = new MeetingInfo()
        {
            Id = 1,
            Location = "İstanbul",
            Date = new DateTime(2024, 12, 31),
            NumberOfPeople = UserCount
        };
        return View(meetingInfo);
    }
}
