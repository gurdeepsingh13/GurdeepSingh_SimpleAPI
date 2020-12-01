using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleAPI.Controllers
{
    [Route("[controller]")]
    public class RandomController : Controller
    {
        [HttpGet]
        public int Get()
        {
            Random random = new Random();
            double flt = random.NextDouble();
            int shift = Convert.ToInt32(Math.Floor(25 * flt));
            return shift;
        }

        [HttpPost]
        public double Post()
        {
            Random random = new Random();
            double flt = random.NextDouble();
            return flt;
        }

        [HttpPut]
        public String Put()
        {
            return "Thank you for the new number!";
        }

        [HttpDelete]
        public String Delete()
        {
            Random random = new Random();
            double flt = random.NextDouble();
            int shift = Convert.ToInt32(Math.Floor(25 * flt));
            char letter = Convert.ToChar(shift + 65);
            return letter.ToString();
        }

        [HttpPatch]
        public String Patch()
        {
            DateTime date = DateTime.Now;
            return date.ToString();
        }

        [HttpOptions]
        public String Options()
        {
            return "GET : This method return a random integer. \n" +
                "POST: This method return a random double.\n" +
                "PUT: This method return a string. \n" +
                "DELETE: This method return a random character. \n" +
                "PATCH: This method gives the current date. \n" +
                "OPTIONS: This method return text that each HTTP method returns.";
                
        }
    }
}
