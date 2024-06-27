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

        private RecipeManager recipeManager;
        private InputValidator inputValidator;
        private Menu menu;

        public Run() 
        {
            recipeManager = new RecipeManager();
            menu = new Menu();
            inputValidator = new InputValidator(recipeManager, menu);
        }

        //------------------------------------------------------------------------

        /// <summary>
        /// Method to add to the Recipe list
        /// </summary>

        //------------------------------------------------------------------------

        private void AddRecipe(
        string Name, 
        int NumberSteps, 
        int NumberIngreds, 
        List<string> IngredName, 
        List<string> IngredQuan,
        List<string> IngredUOM,
        List<string> Description,
        List<string> Foodgroup,
        List<int> Calories,
        int TotalCalories
        )
        {
            string name = Name;
            int numberSteps = NumberSteps;
            int numberIngreds = NumberIngreds;

            List<string> ingredName = IngredName;
            List<string> ingredQuan = IngredQuan;
            List<string> ingredUOM = IngredUOM;
            List<string> description = Description;
            List<int> calories = Calories;
            List<string> foodgroup = Foodgroup;
            int totalCalories = TotalCalories;

            string[] localGroups = inputValidator.getFoodGroupList();

            Console.WriteLine("When prompted, enter in the food group for your ingredient from this list:");
            for (int i = 0; i < localGroups.Length; i++)
            {
                Console.WriteLine($"{localGroups[i]}");
            }

            for (int i = 0; i < numberIngreds; i++)
            {
                //Ingredient name
                Console.WriteLine($"Enter the name of ingredient {i + 1}:");
                string Ingredname = Console.ReadLine();
                if (!inputValidator.IsValidIngredientName(Ingredname))
                {
                    Console.WriteLine("Invalid ingredient name. Please try again.");
                    return;
                }
                ingredName.Add(name);

                //Ingredient quantity
                Console.WriteLine($"Enter the quantity of ingredient {i + 1}:");
                double quantity = double.Parse(Console.ReadLine());
                if (!inputValidator.IsValidIngredientQuantity(quantity))
                {
                    Console.WriteLine("Invalid ingredient quantity. Please try again.");
                    return;
                }
                ingredQuan.Add(quantity.ToString());

                //Ingredient measuremeant
                Console.WriteLine($"Enter the unit of measurement for ingredient {i + 1}:");
                string unit = GetValidUnit();
                if (unit == null)
                {
                    return;
                }
                ingredUOM.Add(unit);

                //Ingredient calories
                Console.WriteLine($"Enter the total amount of calories for ingredient {i + 1}:");
                int amount = int.Parse(Console.ReadLine());
                if (!inputValidator.IsValidCaloryCount(amount))
                {
                    Console.WriteLine("Invalid number of calories. Please try again.");
                    return;
                }
                calories.Add(amount);

                //Ingredient food group
                Console.WriteLine($"Enter the food group for ingredient {i + 1}:");
                string group = Console.ReadLine();
                if (!inputValidator.IsValidFoodGroupItem(group))
                {
                    return;
                }
                foodgroup.Add(group);
            }

            for (int i = 0; i < numberSteps; i++)
            {
                Console.WriteLine($"Enter the description for step {i + 1}:");
                string desc = Console.ReadLine();
                if (!inputValidator.IsValidStepDescription(desc))
                {
                    Console.WriteLine("Invalid step description. Please try again.");
                    return;
                }
                description.Add(desc);
            }

            for (int i = 0; i < calories.Count; i++)
            {
                totalCalories = +calories[i];
            }

            Recipe recipe = new Recipe
                (
                name,
                numberSteps,
                numberIngreds,
                ingredName,
                ingredQuan,
                ingredUOM,
                description,
                foodgroup,
                calories,
                totalCalories
                );

            recipeManager.AddRecipe(recipe);

            Console.WriteLine("Recipe added successfully!");
        }

        //------------------------------------------------------------------------










        //------------------------------------------------------------------------

        /// <summary>
        /// Method to retrieve the Unit of measurement dictionary from the Input Validator
        /// </summary>
        /// <returns></returns>

        //------------------------------------------------------------------------

        private string GetValidUnit()
        {
            string unit = Console.ReadLine();

            if (inputValidator.IsValidIngredientUnit(ref unit))
            {
                return unit;
            }
            else
            {
                Console.WriteLine("Invalid unit of measurement. Please try again.");
                return null;
            }
        }
        //------------------------------------------------------------------------
    }
}

//---------------------------------------------------end-------------------------------------------------------