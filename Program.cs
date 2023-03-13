class Program
{
    static void Main(string[] args)
    {
        int dayofweek; 
        int timeofday;
        string menu;
        int breakfastset = 5, weekendset = 2, coffee = 3;

            Console.Write("Enter day of week : ");
            dayofweek = int.Parse(Console.ReadLine());

            Console.Write("Enter time of day : ");
            timeofday = int.Parse(Console.ReadLine());
            
        while (true)
        {

            Console.Write("Enter menu: ");
            menu = Console.ReadLine();

            switch (menu)
            {
                case "Breakfast Set":
                    if (dayofweek == 6 || dayofweek == 7 ||  timeofday <= 11)
                    {
                        if (breakfastset == 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                            continue;
                        }
                        breakfastset--;

                    }
                    else
                    {
                        Console.WriteLine("Sorry your order is not available");
                        continue;
                    }
                    break;

                case "Weekend Set":
                    if (dayofweek == 1 || dayofweek == 2 || dayofweek == 3 || dayofweek == 4 || dayofweek == 5)
                    {
                        if (weekendset == 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                            continue;
                        }
                        weekendset--;
                    }
                    else
                    {
                        Console.WriteLine("Sorry your order is not available");
                        continue;
                    }
                    break;

                case "Coffee":
                    if (coffee == 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                        continue;
                    }
                    coffee--;
                    break;

                default:
                    Console.WriteLine("Please enter a valid menu");
                    continue;
            }

            Console.Write("");
            string choice = Console.ReadLine().ToLower();
            if (choice == "End")
            {
                break;
            }
        }
    }
}