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
        private Type Type { set; get; }
        private Size Size { set; get; }
        private Combo Combo { set; get; }

        static double GetTypePrice(Type type)
        {
            double price = 0;

            switch (type)
            {
                case Type.TheBackStreetBoys:
                    price = 12.95;
                    break;
                case Type.TheBeyonce:
                    price = 22.95;
                    break;
                case Type.TheBillieEilish:
                    price = 8.95;
                    break;
                case Type.TheBTS:
                    price = 15.95;
                    break;
                case Type.TheMichealJackson:
                    price = 18.95;
                    break;
                case Type.ThePrince:
                    price = 64.95;
                    break;
            }

            return price;
        }

        static double GetSizePrice(Size size)
        {
            double price = 0;

            switch (size)
            {
                case Size.onehitwonder: break;
                case Size.blist:
                    price = 2.5;
                    break;
                case Size.alist:
                    price = 5.0;
                    break;
                case Size.superstar:
                    price = 9.65;
                    break;
            }

            return price;
        }

        static double GetComboPrice(Combo combo)
        {
            double price = 0;

            switch (combo)
            {
                case Combo.None:break;
                case Combo.CookiesNDrink:
                    price = 3.75;
                    break;
                case Combo.ChipsNDrink:
                    price = 4.50;
                    break;
            }

            return price;
        }
        //I have no clue what I am doing

    }
}