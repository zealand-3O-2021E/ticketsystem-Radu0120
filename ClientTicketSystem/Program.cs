using ClassLibraryTicketSystem;
using StoreBaeltTicketLibrary;
using OresundbronTicketLibrary;
using System;

namespace ClientTicketSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to our Ticket System!");
            Console.WriteLine("Our commands are case insensitive");
            Console.WriteLine();
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Customer customer = new Customer(name);
            string input = "";

            while (input != "n") {
                Console.WriteLine("From which company do you wish to order?");
                Console.WriteLine("StoreBaelt | Oresundbron");

                while (input != "stop") {
                    input = Console.ReadLine().ToLower();
                    if (input == "storebaelt")
                    {
                        ShopatStorebaelt(customer);
                        break;
                    }
                    else if (input == "oresundbron")
                    {
                        ShopatOresundbron(customer);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice, please try again or type stop to exit.");
                    }
                }
                Console.WriteLine("Do you wish to make another order?(Y/N)");
                input = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Thank you for using our system!");
            Console.WriteLine("Your list contains:");
            Console.WriteLine(customer.ListInfo());
            Console.WriteLine("And your total bill is " + customer.Bill() + " kr.");
        }
        public static void ShopatStorebaelt(Customer c)
        {
            Console.WriteLine("Do you want to order a car ticket or a mc ticket?");
            string input = "";
            while (input != "stop")
            {
                string[] order = new string[2];
                bool brobizz = false; ;
                input = Console.ReadLine().ToLower();
                if(input == "car")
                {
                    order = MakeOrder();
                    if (order[1] == "y") brobizz = true;
                    else brobizz = false;
                    c.Trips.Add(new StoreBaeltCar(order[0], DateTime.Now, brobizz));
                    break;
                }
                else if(input == "mc")
                {
                    order = MakeOrder();
                    if (order[1] == "y") brobizz = true;
                    else brobizz = false;
                    c.Trips.Add(new MC(order[0], DateTime.Now, brobizz));
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again or type stop to exit.");
                }
            }
        }
        public static void ShopatOresundbron(Customer c)
        {
            Console.WriteLine("Do you want to order a car ticket or a mc ticket?");
            string input = "";
            while (input != "stop")
            {
                string[] order = new string[2];
                bool brobizz = false; ;
                input = Console.ReadLine().ToLower();
                if (input == "car")
                {
                    order = MakeOrder();
                    if (order[1] == "y") brobizz = true;
                    else brobizz = false;
                    c.Trips.Add(new OresundBronCar(order[0], DateTime.Now, brobizz));
                    break;
                }
                else if (input == "mc")
                {
                    order = MakeOrder();
                    if (order[1] == "y") brobizz = true;
                    else brobizz = false;
                    c.Trips.Add(new OresundBronMC(order[0], DateTime.Now, brobizz));
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again or type stop to exit.");
                }
            }
        }
        public static string[] MakeOrder()
        {
            string brobizz = "";
            string license = "";
            Console.WriteLine("Enter the license plate: ");
            license = Console.ReadLine().ToLower();
            Console.WriteLine("Do you have a brobizz?(Y/N): ");
            brobizz = Console.ReadLine().ToLower();

            string[] order = new string[] { license, brobizz};
            return order;
        }
    }
}
