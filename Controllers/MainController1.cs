using Microsoft.AspNetCore.Mvc;

namespace mvc1.Controllers
{
    public class MainController1 : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Index(string t1, int t2)
        {
            double inr = t2 * 105;
            ViewBag.res = "Amount in Inr From Sterling Pound  :" + inr;
            return View();

        }
        
        public IActionResult Process(string t1, int t2)
        {
            string res = "";
            string rvalue = "";
            if(t2>=151 && t2<=200)
            {
                res = "Normal";
                rvalue = "2points";
            }
            else if(t2>=201 && t2>=250) 
            {
                res = "Moderate";
                rvalue = "4points";
            }
            else if (t2 >= 251 && t2 >= 300)
            {
                res = "Critical";
                rvalue = "6points";
            }
            else if (t2 >= 301 && t2 >= 3500)
            {
                res = "Highly Critical";
                rvalue = "8points";
            }
            else if (t2 >= 351 && t2 >= 400)
            {
                res = "Extremly Critical";
                rvalue = "10points";
            }
            else 
            {
                res = "Dose Not Recomended";
                rvalue = "Please Consult Docter";
            }
            ViewBag.res = res;
            ViewBag.rValue = rvalue;
            return View();
        }

    }
}
