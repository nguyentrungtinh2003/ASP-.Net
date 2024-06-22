using System;
using System.Threading.Tasks;

namespace Buổi_3_ASP.Models
{
    public class DemoAsyn
    {
        public static async Task<int> FuncAAsync()
        {
            await Task.Delay(2000); // 2 seconds delay
            return new Random().Next(1, 100);
        }

        public static async Task<string> FuncBAsync()
        {
            await Task.Delay(5000); // 5 seconds delay
            return "FuncB";
        }

        public static async Task<string> FuncCAsync()
        {
            await Task.Delay(3000); // 3 seconds delay
            return "FuncC";
        }
    }
}
