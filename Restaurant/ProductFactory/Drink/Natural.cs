using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantConsoleApp
{
    class Natural : Product 
    {
        public Natural(Type type, string name, double price) : base(type, name, price)
        {
            this.Description = "250 ml.";
        }
        protected override void SetVAT()
        {
            VAT = 5;
        }

        public override string ToString()
        {
            return $"{Type} with name: {Name} -> price: {Price + Price * (VAT / 100)} ";
        }
    }
}
