using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sheet4.Models
{
    enum Type{
        TheMichealJackson,
        ThePrince,
        TheBackStreetBoys,
        TheBeyonce,
        TheBillieEilish,
        TheBTS
    };

    enum Size
    {
        onehitwonder,
        blist,
        alist,
        superstar
    }

    enum Combo
    {
        None,
        ChipsNDrink,
        CookiesNDrink
    }
    public class HomeModel
    {
        private Type type { set; get; }
        private Size size { set; get; }
        private Combo combo { set; get; }
    }
}