using Buổi_3_ASP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Buổi_3_ASP.Controllers
{
    public class SyncDemoController : Controller
    {
        public async Task<IActionResult> SyncDemo()
        {
            var sv = new Stopwatch();
            sv.Start();

            var a =  DemoAsyn.FuncAAsync();
            var b = DemoAsyn.FuncBAsync();
            var c = DemoAsyn.FuncCAsync();
            await a; await b; await c;

            sv.Stop(); // Stop the stopwatch to get the elapsed time

            return Content($"Chay het {sv.ElapsedMilliseconds} ms");
        }
    }
}
