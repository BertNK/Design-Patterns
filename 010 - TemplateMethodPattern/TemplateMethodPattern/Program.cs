using TemplateMethodPattern.CompareTo;

namespace TemplateMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleTea simpleTea = new SimpleTea();
            SimpleCoffee simpleCoffee = new SimpleCoffee();

            simpleTea.prepareRecipe();
            simpleCoffee.PrepareRecipe();

            Console.WriteLine("\n\nNow with abstracted classes\n\n");

            CaffeineBeverage tea = new Tea();
            CaffeineBeverage coffee = new Coffee();
            CaffeineBeverage chocolateMilk = new ChocolateMilk();

            tea.PrepareRecipe();
            coffee.PrepareRecipe();
            chocolateMilk.PrepareRecipe();

            Console.WriteLine("\n\n Now with hooked classes\n\n");
            CaffeineBeverageWithHook soda = new SodaWithHook();
            soda.PrepareRecipe();

            // You'll need this method for the second part of the Template Method Pattern
            /*Duck[] ducks =
            {
                new Duck("Daffy", 8),
                new Duck("Dewey", 2),
                new Duck("Howard", 7),
                new Duck("Louie", 2),
                new Duck("Donald", 10),
                new Duck("Huey", 2)
            };

            Console.WriteLine("Before sorting:");
            Display(ducks);*/
        }

        // You'll need this method for the second part of the Template Method Pattern
        public static void Display(object[] objects)
        {
            foreach (object o in objects)
            {
                Console.WriteLine(o.ToString());
            }
            Console.WriteLine("");
        }
    }
}