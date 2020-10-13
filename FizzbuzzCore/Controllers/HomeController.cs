using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FizzbuzzCore.Models;
using System.Text;

namespace FizzbuzzCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Solve()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Solve(string fizzIn, string buzzIn)
        {
            var fbModel = new FizzbuzzModel();
            fbModel.FizzNum = Convert.ToInt32(fizzIn);
            fbModel.BuzzNum = Convert.ToInt32(buzzIn);
            var output = new StringBuilder();
            for(var index = 1; index <= 100; index++)
            {
                if(index % fbModel.FizzNum == 0 && index % fbModel.BuzzNum == 0)
                {
                    output.AppendLine("FIZZBUZZ!");
                }
                else if(index % fbModel.FizzNum == 0)
                {
                    output.AppendLine("Fizz");
                }
                else if(index % fbModel.BuzzNum == 0)
                {
                    output.AppendLine("Buzz");
                }
                else
                {
                    output.AppendLine(index.ToString());
                }
            }
            fbModel.Output = $"{output}";
            return RedirectToAction("Result", fbModel);
        }       
        public IActionResult Result(FizzbuzzModel model)
        {
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
