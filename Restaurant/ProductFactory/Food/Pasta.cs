using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantConsoleApp
{
    class Pasta : Product
    {
        public Pasta(Type type, string name, double price) : base(type, name, price)
        {
            this.Description = "100 gr.";
        }
        protected override void SetVAT()
        {
            VAT = 9;
        }
        public override string ToString()
        {
            return $"{Type} with name: {Name} -> price: {Price + Price * (VAT / 100)} \nDescription: {Description}";
        }
    }
}
