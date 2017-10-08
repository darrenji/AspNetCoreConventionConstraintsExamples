using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreConventionAndConstraintsExample.Models;
using AspNetCoreConventionAndConstraintsExample.Infrastructure;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreConventionAndConstraintsExample.Controllers
{
    //[AdditionalActions]
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View("Result", new Result {
                Controller = nameof(HomeController),
                Action = nameof(Index)
            });
        }

        [ActionName("Index")]
        [UserAgent("Edge")]
        public IActionResult Other() => View("Result", new Result
        {
            Controller = nameof(HomeController),
            Action = nameof(Other)
        });


        //[ActionName("Details")]
        //[ActionNamePrefix("Do")]
        [AddAction("Details")]
        public IActionResult List() => View("Result", new Result {
            Controller = nameof(HomeController),
            Action=nameof(List)
        });
    }
}
