using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sheet4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Receipt(FormCollection form)
        {
            double[] typePrice = new double[]
            {
                12.95,  //TheMichealJackson
                22.95,  //ThePrince
                16.95,  //TheBackStreetBoys
                17.95,  //TheBeyonce
                5.95,   //TheBillieEilish; Value option
                64.95   //TheBTS; Premium option
            };

            double[] sizePrice = new double[]
            {
                1.00,   //onehitwonder
                1.50,   //blist
                2.00,   //alist
                5.00    //superstar
            };

            double[] comboPrice = new double[]
            {
                0.00,   //None
                1.65,   //ChipsNDrink
                2.45    //CookiesNDrink
            };
           
           //A little bit more of a clue but still not quite sure what I'm up to.

            return View();
        }
    }
}