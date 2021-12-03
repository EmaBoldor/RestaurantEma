using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantConsoleApp
{
    public abstract class Product
    {
        public string Name { get; set; }
        public Type Type { get; }
        public double Price { get; set; }
        public string Description { get; set; } = "";
        public double VAT { get; protected set; }

        protected Product(Type type, string name, double price)
        {
            Name = name;
            Type = type;
            Price = price;
            SetVAT();
        }
        public Product setDescription(string description)
        {
            this.Description += description;
            return this;
        }

        protected abstract void SetVAT();

        public override string ToString()
        {
            return $"{Type} with name: {Name} -> price: {Price} ";
        }
    }
}
