using KomodoCafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe_Console
{
    class ProgramUI
    {
        private MenuRepo _menuRepo = new MenuRepo();

        // Start
        private void Run()
        {
            Menu();
        }

        // Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                // Display options
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Menu Item\n" +
                    "2. View List Of Menu Items\n" +
                    "3. View Menu Item By Number" +
                    "4. Delete A Menu Item\n" +
                    "5. Exit");

                // Get input

                // Evaluate input and act accordingly
            }
        }

        // Create New Menu Item

        // Display All Menu Items

        // View Menu Item By Number

        // Remove Existing Menu Item
    }
}
