using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_ST10067956
{
    public class MenuItem
    {
        //------------------------------------------------------------------------

        /// <summary>
        /// Constructor for the MenuItem
        /// </summary>
        /// <param name="recipeName"></param>
        /// <param name="totalIngred"></param>
        /// <param name="foodGroup"></param>
        /// <param name="ingredPer"></param>

        //------------------------------------------------------------------------

        public MenuItem(string recipeName, int totalIngred, List<string> foodGroup, double[] ingredPer)
        {
            RecipeName = recipeName;
            TotalIngred = totalIngred;
            FoodGroup = foodGroup;
            IngredPer = ingredPer;
        }

        //------------------------------------------------------------------------

        /// <summary>
        /// All the getters and setters for the variables
        /// </summary>

        //------------------------------------------------------------------------

        public string RecipeName { get => RecipeName; set => RecipeName = value; }
        public int TotalIngred { get => TotalIngred; set => TotalIngred = value; }
        public List<string> FoodGroup { get => FoodGroup; set => FoodGroup = value; }
        public double[] IngredPer { get => IngredPer; set => IngredPer = value; }

        //------------------------------------------------------------------------
    }
}

//---------------------------------------------------end-------------------------------------------------------
