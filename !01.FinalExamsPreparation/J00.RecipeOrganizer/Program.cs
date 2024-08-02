using System.Net.Http.Headers;

namespace J00.RecipeOrganizer
{
    public class Recipe
    {
        public string NameOfRecipe { get; set; }
        public string Ingredients { get; set; }

        public Recipe(string nameOfRecipe, string ingredients)
        {
            NameOfRecipe = nameOfRecipe;
            Ingredients = ingredients;
        }

        public override string ToString()
        {
            return $"{NameOfRecipe}: {Ingredients}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Dictionary<string, Recipe> dictOfRecipies = new Dictionary<string, Recipe>();

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] commands = input.Split(" ").ToArray();

                string command = commands[0];

                if (command == "AddRecipe")
                {
                    string recipeName = commands[1];
                    string[] ingredients = commands.TakeLast(commands.Length - 2).ToArray();

                    if (dictOfRecipies.ContainsKey(recipeName))
                    {
                        dictOfRecipies[recipeName].Ingredients = string.Join(" ",ingredients);
                    }
                    else
                    {
                        Recipe newRecipe = new Recipe(recipeName, string.Join(" ", ingredients));
                        dictOfRecipies.Add(recipeName, newRecipe);
                    }
                }
                if (command == "RemoveRecipe")
                {
                    string recipeName = commands[1];
                    if (dictOfRecipies.ContainsKey(recipeName))
                    {
                        dictOfRecipies.Remove(recipeName);
                    }
                }
                if (command == "UpdateRecipe")
                {
                    string recipeName = commands[1];
                    string[] newIngredients = commands.TakeLast(commands.Length - 2).ToArray();

                    if (dictOfRecipies.ContainsKey(recipeName))
                    {
                        dictOfRecipies[recipeName].Ingredients = string.Join(" ", newIngredients);
                    }
                }
                if (command == "ListRecipes")
                {
                    var sortedDict = dictOfRecipies.Values.OrderBy(pairs => pairs.NameOfRecipe);
                    foreach (Recipe recipe in sortedDict)
                    {
                        Console.WriteLine(recipe);
                    }
                }

            }
        }
    }
}
