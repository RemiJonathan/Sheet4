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
    public class HomeModel
    {
        private Type type { set; get; }
    }
}