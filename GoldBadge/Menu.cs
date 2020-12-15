using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe
{
    public class Menu
    {
        private readonly MenuRepo _menuRepo = new MenuRepo();

        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public List<String> Ingredients { get; set; }
        public decimal Price { get; set; }

        public Menu() { }
        public Menu(int mealNumber, string mealName, string description, List<String> ingredients, decimal price)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            Ingredients = ingredients;
            Price = price;
        }
    }
}
