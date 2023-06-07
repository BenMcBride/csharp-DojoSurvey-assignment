using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;
public class HomeController : Controller
{
  [HttpGet("")]
  public ViewResult Index()
  {
    return View("Index");
  }

  [HttpPost("result")]
  public IActionResult Result(string name, string location, string language, string comment)
  {
    ViewBag.name = name;
    ViewBag.location = location;
    ViewBag.language = language;
    ViewBag.comment = comment;
    return View();
  }

  [HttpGet("result")]
  public RedirectToActionResult Redirect()
  {
    return RedirectToAction("Index");
  }
}