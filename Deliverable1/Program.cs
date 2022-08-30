using System;

class MainClass
{


    public static void Main(string[] args)
    {
        // *** Set variables: 1 Sandwich Per Person, 1 Loaf Of Bread == 28 Slices, 1 Jar Of Peanut Butter == 32 Tablespoons, 1 Jar Of Jelly == 48 Teaspoons.
        // Each Sandwich Requires 2 Slices Of Bread, 2 Tablespoons Of Peanut Butter, 4 Teaspoons Of Jelly ***//


        var IsRestartRequired = false;

        var padding = "".PadLeft(4, '-');

        {
            while (!IsRestartRequired)
            {
                //Get Number Of Guests//
                Console.WriteLine("How Many People Are We Making PB And J Sandwiches For? \n" +
                    padding);

                if (int.TryParse(Console.ReadLine(), out var numberOfGuests))
                {
                    Console.WriteLine(padding);
                    var service = new PBandJService(numberOfGuests);
                    var results = service.GetResults();

                    Console.WriteLine(results);
                }
                else
                {
                    Console.WriteLine("Could not determine the number of people.\n");

                }

                Console.WriteLine("Would You Like To Restart? Enter Yes or y To Continue. Or Press Any Other Key To Exit.");
                var restartResponse = Console.ReadLine();
                //Restart Or Quit Program//
                if (restartResponse?.ToLower() is "yes" or "y")
                {
                    IsRestartRequired = false;
                    Console.Clear();
                }
                else
                { IsRestartRequired = true; }
            }

        }
        Console.WriteLine("Goodbye!");
    }
}