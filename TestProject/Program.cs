using System;
using TestProject.Functions;
using TestProject.Models;

namespace TestProject
{
    class Program
    {
        static void Mian(string[] args)
        {
            Data birdData = new Data();

            BirdCount birdCountFunctions = new BirdCount(birdData);

            while (true)
            {
                
                Console.WriteLine("-- Wellcome to the Bird Watcher --");
                Console.WriteLine("1. Update the date.");
                Console.WriteLine("2. Check the number.");

                string user = Console.ReadLine();

                switch (user)
                {
                    case "1":
                        Console.WriteLine("Which date do you want to enter data for?");
                        Console.WriteLine("Today(1) / The last week(2).");

                        string DataChosen = Console.ReadLine();
                        if (DataChosen == "1")
                        {
                            birdCountFunctions.Today();
                        }
                        else if (DataChosen == "2")
                        {
                            
                        }
                        break;

                    case "2":
                    Console.WriteLine("Which date do you want to view data for?");
                        Console.WriteLine("This week(1) / The last week(2).");

                        string WeekChosen = Console.ReadLine();
                        if (WeekChosen == "1")
                        {
                            
                        }
                        else if (WeekChosen == "2")
                        {

                        }
                        break;
                    default:
                        Console.WriteLine("Invaild input, please choose again.");
                        break;
                }

            }
        }
    }
}
