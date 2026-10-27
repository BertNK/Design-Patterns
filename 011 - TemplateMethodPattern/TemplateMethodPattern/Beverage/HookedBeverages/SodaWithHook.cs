namespace TemplateMethodPattern
{
    internal class SodaWithHook : CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Mixing soda syrup with carbonated water");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding ice and lemon");
        }

        public override bool CustomerWantsCondement()
        {
            Console.WriteLine("Would you like ice and lemon with your soda (y/n)?");
            string answer = Console.ReadLine() ?? string.Empty;
            return answer.StartsWith("y", StringComparison.OrdinalIgnoreCase);
        }
    }
}
