using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PROG6221_POE_ST10067956
{
    /// <summary>
    /// This classes purpose is to collect all the variables and methods to one place so that it's accessible 
    /// by the rest of the app
    /// </summary>
    public class Run
    {
        //------------------------------------------------------------------------

        //Calling the coresponding classes that will be used here
        private RecipeManager recipeManager;
        private Menu menu;

        public Run() 
        {
            recipeManager = new RecipeManager();
            menu = new Menu();
        }

        //------------------------------------------------------------------------

        /// <summary>
        /// Method to add to this Recipe list
        /// </summary>

        //------------------------------------------------------------------------

        void AddRecipe(Recipe newRecipe)
        {
            recipeManager.AddRecipe(newRecipe);
        }

        //------------------------------------------------------------------------

        /// <summary>
        /// EditRecipe method to make changes to an existing recipe in the recipe manager class
        /// </summary>

        //------------------------------------------------------------------------

        void EditRecipe(Recipe newRecipe, string RecipeName)
        {
            recipeManager.EditRecipe(RecipeName, newRecipe);
        }

        //------------------------------------------------------------------------

        /// <summary>
        /// DeleteRecipe method to delete a recipe from the recipe manager class
        /// </summary>

        //------------------------------------------------------------------------

        void DeleteRecipe(string recipeName)
        {
            recipeManager.DeleteRecipe(recipeName);
        }

        //------------------------------------------------------------------------

        /// <summary>
        /// Method to retrieve the recipe the user is looking for
        /// </summary>
        /// <param name="recipeName"></param>
        /// <returns></returns>

        //------------------------------------------------------------------------

        Recipe ViewRecipe(string recipeName)
        {
            return recipeManager.GetAllRecipes().FirstOrDefault(r => r.Name == recipeName);
        }

        //------------------------------------------------------------------------

        /// <summary>
        /// Method to add a new item to the menu
        /// </summary>
        /// <param name="item"></param>

        //------------------------------------------------------------------------

        void AddItem(MenuItem item)
        {
            menu.AddMenuItem(item);
        }

        //------------------------------------------------------------------------

        /// <summary>
        /// Method to delete a menu item
        /// </summary>
        /// <param name="RecipeName"></param>

        //------------------------------------------------------------------------

        void DeleteItem(string RecipeName)
        {
            menu.DeleteMenuItem(RecipeName);
        }

        //------------------------------------------------------------------------
    }
}

//---------------------------------------------------end-------------------------------------------------------