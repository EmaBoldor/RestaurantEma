using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Cash
{
    class Cash
    {
        public static double Price = 0;
        public static string Products = "";
        public static double Total = 0;

        public static void total(double price, double vat, string name)
        {
            Total += (price + price * (vat / 100));
        }
       
    }
}
