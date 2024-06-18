namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to order steak or shrimp?");
            string userInput = Console.ReadLine();
            IOrderable instance = FoodFactory.OrderFood(userInput);

            instance.OrderDescription();
            Console.WriteLine(instance.Price);

        }
    }
}
