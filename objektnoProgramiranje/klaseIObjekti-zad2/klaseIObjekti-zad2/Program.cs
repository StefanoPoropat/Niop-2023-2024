using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klaseIObjekti_zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FoodType foodType = new FoodType("banana", 4, 93, 3);
            Food food = new Food(foodType, 110);
            Console.WriteLine("Food Type: " + foodType);
            Console.WriteLine(food.ToStringInGrams());
            Console.ReadKey();
        }
    }
}
