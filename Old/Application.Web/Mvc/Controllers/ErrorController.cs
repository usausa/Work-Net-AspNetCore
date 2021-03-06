namespace Application.Web.Mvc.Controllers
{
    using System.Diagnostics;

    using Application.Web.Mvc.Infrastructure;
    using Application.Web.Mvc.Models;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [AllowAnonymous]
    public class ErrorController : BaseMvcController
    {
        public IActionResult Index()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Forbidden()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
