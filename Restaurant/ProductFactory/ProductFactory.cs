using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantConsoleApp
{
    public static class ProductFactory
    {
        public static Product CreateProduct(string name, Type type, double price)
        {
            switch (type)
            {
                case Type.Natural:
                    return new Natural(type, name, price);
                case Type.Soda:
                    return new Soda(type, name, price);
                case Type.Pizza:
                    return new Pizza(type, name, price);
                case Type.Pasta:
                    return new Pasta(type, name, price);
                case Type.Meat:
                    return new Meat(type, name, price);
                case Type.Desert:
                    return new Desert(type, name, price);
                case Type.Sauce:
                    return new Sauce(type, name, price);
                case Type.SlideDish:
                    return new SlideDish(type, name, price);
                default:
                    return null;
            }
        }
    }
}
