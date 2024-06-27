using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_ST10067956
{
    public class Menu
    {
        private List<MenuItem> MenuItems;

        public Menu()
        {
            MenuItems = new List<MenuItem>();
        }

        //------------------------------------------------------------------------

        /// <summary>
        /// Method to add to the menu list
        /// </summary>
        /// <param name="Item"></param>

        //------------------------------------------------------------------------

        public void AddMenuItem(MenuItem Item)
        {
            MenuItems.Add(Item);
        }

        //------------------------------------------------------------------------

        /// <summary>
        /// Method to delete a menu Item
        /// </summary>
        /// <param name="recipeName"></param>
        /// <returns></returns>

        //------------------------------------------------------------------------

        public bool DeleteMenuItem(string recipeName)
        {
            var Item = GetItem(recipeName);
            if (Item != null)
            {
                MenuItems.Remove(Item);
                return true;
            }
            return false;
        }

        //------------------------------------------------------------------------

        /// <summary>
        /// Method to retrieve an Item from the list
        /// </summary>
        /// <param name="recipeName"></param>
        /// <returns></returns>

        //------------------------------------------------------------------------

        public MenuItem GetItem(string recipeName)
        {
            return MenuItems.FirstOrDefault(r => r.RecipeName == recipeName);
        }

        //------------------------------------------------------------------------

        /// <summary>
        /// Method to retrieve all the Items in the MenuItem list
        /// </summary>
        /// <returns></returns>

        //------------------------------------------------------------------------

        public List<MenuItem> GetAllItems()
        {
            return MenuItems;
        }

        //------------------------------------------------------------------------
    }
}

//---------------------------------------------------end-------------------------------------------------------