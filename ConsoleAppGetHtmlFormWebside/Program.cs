using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace ConsoleAppGetHtmlFormWebside
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient webClient = new WebClient();

            var htmlResponse = webClient.DownloadString("https://www.power.dk/search/?q=computer");


            Console.ReadKey();
        }
    }
}
