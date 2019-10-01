using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sheet4.Models
{
    public enum Type{
        TheMichealJackson,
        ThePrince,
        TheBackStreetBoys,
        TheBeyonce,
        TheBillieEilish,
        TheBTS
    };

    public enum Size
    {
        onehitwonder,
        blist,
        alist,
        superstar
    }

    public enum Combo
    {
        None,
        ChipsNDrink,
        CookiesNDrink
    }
    public class HomeModel
    {
        public Type Type { set; get; }
        public Size Size { set; get; }
        public Combo Combo { set; get; }
        //I have no clue what I am doing
    }
}