using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantConsoleApp
{ 
    class Soda : Product
    {
        public Soda(Type type, string name, double price) : base(type, name, price)
        {
            this.Description = "250 ml.";
        }
        protected override void SetVAT()
        {
            VAT = 12;
        }
        public override string ToString()
        {
            return $"{Type} with name: {Name} -> price: {Price + Price * (VAT / 100)}";
        }
    }
}
