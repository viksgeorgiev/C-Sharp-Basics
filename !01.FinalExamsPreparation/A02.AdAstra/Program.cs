using System.Text.RegularExpressions;

namespace A02.AdAstra
{
    public class Food
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public int Calories { get; set; }
        public Food(string name, string date, int calories)
        {
            Name = name;
            Date = date;
            Calories = calories;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Food> foodsList = new List<Food>();

            string pattern = @"([|#])([A-Za-z ]+)\1(\d{2}\/\d{2}\/\d{2})\1(\d{1,5})\1";
            
            foreach (Match match in Regex.Matches(input, pattern))
            {
                string nameOfItem = match.Groups[2].Value;
                string dateOfExpire = match.Groups[3].Value;
                int caloriesOfItem = int.Parse(match.Groups[4].Value);

                Food newFood = new Food(nameOfItem, dateOfExpire, caloriesOfItem);
                
                foodsList.Add(newFood);
            }

            int allFoodsCaloriesSum = foodsList.Sum(food => food.Calories);
            int daysCanSurvive = allFoodsCaloriesSum / 2000;
            Console.WriteLine($"You have food to last you for: {daysCanSurvive} days!");
            foreach (Food food in foodsList)
            {
                Console.WriteLine($"Item: {food.Name}, Best before: {food.Date}, Nutrition: {food.Calories}");
            }
        }
    }
}
