using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klaseIObjekti_2
{
    internal class FoodType
    {
        string name;
        int proteini, carbs, fat;

        public FoodType(string name, int proteini, int carbs, int fat)
        {
            this.name = name;
            this.proteini = proteini;
            this.carbs = carbs;
            this.fat = fat;
        }
        public override string ToString()
        {
            string thing = name + ": " + proteini+"";

            return thing;
        }
    }
}
