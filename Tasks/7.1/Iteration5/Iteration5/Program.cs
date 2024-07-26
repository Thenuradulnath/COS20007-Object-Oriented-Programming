namespace Iteration5
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name, description;
            Item item1, item2, item3;
            Bag bag0;
            LookCommand command = new LookCommand();

            item1 = new Item(new string[] { "computer" }, "a computer", "a small computer");
            item2 = new Item(new string[] { "bottle" }, "a bottle", "a white water bottle");
            item3 = new Item(new string[] { "pen" }, "a pen", "a black pen");

            bag0 = new Bag(new string[] { "bag" }, "a bag", "black color bag");

            Console.WriteLine("Enter Player Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter Player Description: ");
            description = Console.ReadLine();

            Player Player1 = new Player(name, description);
            Player1.Inventory.Put(item1);
            Player1.Inventory.Put(item2);
            Player1.Inventory.Put(bag0);
            bag0.Inventory.Put(item3);

            while (true)
            {
                Console.WriteLine("Command: ");
                string userInput = Console.ReadLine();

                if (userInput == "stop")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(command.Execute(Player1, userInput.Split()));
                }
            }
        }
    }
}