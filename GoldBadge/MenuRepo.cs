using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe
{
    public class MenuRepo
    {
        private readonly List<Menu> _menuList = MenuDatabase._menu;

        // Create
        public void AddMenuItem(Menu menuItem)
        {
            _menuList.Add(menuItem);
        }

        // Read
        public List<Menu> GetMenuList()
        {
            return _menuList;
        }

        // Update - Don't currently need this capability

        // Delete
        public bool RemoveMenuItem(int mealNumber)
        {
            Menu menuItem = GetMenuItemByNumber(mealNumber);

            if (menuItem == null)
            {
                return false;
            }

            int initialCount = _menuList.Count;
            _menuList.Remove(menuItem);

            if (initialCount > _menuList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // Helper - Get menu item by number
        public Menu GetMenuItemByNumber(int mealNumber)
        {
            foreach (Menu menuItem in _menuList)
            {
                if (menuItem.MealNumber == mealNumber)
                {
                    return menuItem;
                }
            }

            return null;
        }
    }
}
