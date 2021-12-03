using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantConsoleApp
{ 
    class Desert : Product
    {
        public Desert(Type type, string name, double price) : base(type, name, price)
        {
            this.Description = "50 gr. ";
        }
        protected override void SetVAT()
        {
            VAT = 10;
        }
        public override string ToString()
        {
            return $"{Type} with name: {Name} -> price: {Price + Price * (VAT / 100)} \nDescription: {Description}";
        }
    }
}
