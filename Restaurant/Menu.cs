using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantConsoleApp
{
    class Menu
    {
        private static List<Product> _instance = new List<Product>();
        private static Menu menu = null;
        private Menu()
        {
            _instance.Add(ProductFactory.CreateProduct("Capriciosa", Type.Pizza, 20));
            _instance.Add(ProductFactory.CreateProduct("Quattro stagioni", Type.Pizza, 20));
            _instance.Add(ProductFactory.CreateProduct("Margherita", Type.Pizza, 20));
            _instance.Add(ProductFactory.CreateProduct("Prosciuto e funghi", Type.Pizza, 20));

            _instance.Add(ProductFactory.CreateProduct("Carbonara", Type.Pasta, 15));
            _instance.Add(ProductFactory.CreateProduct("Sea food", Type.Pasta, 15));
            _instance.Add(ProductFactory.CreateProduct("Gnochi", Type.Pasta, 15));
            _instance.Add(ProductFactory.CreateProduct("Quattro farmoggi", Type.Pasta, 15));

            _instance.Add(ProductFactory.CreateProduct("Chicken", Type.Meat, 12));
            _instance.Add(ProductFactory.CreateProduct("Duck", Type.Meat, 12));
            _instance.Add(ProductFactory.CreateProduct("Hamburger", Type.Meat, 12));
            _instance.Add(ProductFactory.CreateProduct("Steak", Type.Meat, 12));
            _instance.Add(ProductFactory.CreateProduct("Pork chops", Type.Meat, 12));

            _instance.Add(ProductFactory.CreateProduct("French fries", Type.SlideDish, 3));
            _instance.Add(ProductFactory.CreateProduct("Rice", Type.SlideDish, 3));
            _instance.Add(ProductFactory.CreateProduct("Mashed potatoes", Type.SlideDish, 3));

            _instance.Add(ProductFactory.CreateProduct("Ketchup", Type.Sauce, 1));
            _instance.Add(ProductFactory.CreateProduct("Mayo", Type.Sauce, 1));
            _instance.Add(ProductFactory.CreateProduct("Tzatziki", Type.Sauce, 1));

            _instance.Add(ProductFactory.CreateProduct("Lava cake", Type.Desert, 30));
            _instance.Add(ProductFactory.CreateProduct("Icecream", Type.Desert, 10));

            _instance.Add(ProductFactory.CreateProduct("Water", Type.Soda, 5));
            _instance.Add(ProductFactory.CreateProduct("Cola", Type.Soda, 5));
            _instance.Add(ProductFactory.CreateProduct("Fanta", Type.Soda, 5));

            _instance.Add(ProductFactory.CreateProduct("Lemonade", Type.Natural, 10));
            _instance.Add(ProductFactory.CreateProduct("Fresh", Type.Natural, 10));
            _instance.Add(ProductFactory.CreateProduct("Coffee", Type.Natural, 5));
        }

        public static List<Product> getMenuElements()
        {
            return _instance;
        }

       
    }
}
