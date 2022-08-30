using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // *** Set variables: 1 Sandwich Per Person, 1 Loaf Of Bread == 28 Slices, 1 Jar Of Peanut Butter == 32 Tablespoons, 1 Jar Of Jelly == 48 Teaspoons.
        // Each Sandwich Requires 2 Slices Of Bread, 2 Tablespoons Of Peanut Butter, 4 Teaspoons Of Jelly ***//

        double BreadSlicesPerLoaf = 28;
        double PeanutButterTablespoonPerJar = 32;
        double JellyTeaspoonsPerJar = 48;
        bool IsRestartRequired = false;
        String RestartResponce = "";
        String Padding = "    ";
                               
        {while (!IsRestartRequired)
            {
                //Get Number Of Guests//
                Console.WriteLine("How Many People Are We Making PB And J Sandwiches For? \n" +
                    Padding);
                double NumberOfGuests = int.Parse(Console.ReadLine());
                Console.WriteLine(Padding);
                                    
                //Calculate Bread//
                double BreadSlicesRequired = NumberOfGuests * 2;
                double BreadLoafsRequired = Math.Round(BreadSlicesRequired / BreadSlicesPerLoaf);

                //Calculate Peanut Butter//
                double PeanutButterTablespoonRequired = NumberOfGuests * 2;
                double PeanutButterJarsRequired = Math.Round(PeanutButterTablespoonRequired / PeanutButterTablespoonPerJar);

                //Calculate Jelly//
                double JellyTeaspoonsRequired = NumberOfGuests * 4;
                double JellyJarsRequired = Math.Round(JellyTeaspoonsRequired / JellyTeaspoonsPerJar);

                //Print Results//
                Console.WriteLine("To Serve " + NumberOfGuests + ", You Will Need: \n" +
                    Padding);
                Console.WriteLine(
                    Padding + BreadSlicesRequired + " Slices Of Bread \n" +
                    Padding + PeanutButterTablespoonRequired + " Tablespoons Of PeanutButter \n" +
                    Padding + JellyTeaspoonsRequired + " Teaspoons Of Jelly \n" +
                    Padding);

                Console.WriteLine("Which Is: \n " +
                    Padding);
                Console.WriteLine(
                    Padding + BreadLoafsRequired + " Loafs Of Bread \n" +
                    Padding + PeanutButterJarsRequired + " Jars Of Peanut Butter \n" +
                    Padding + JellyJarsRequired + " Jars Of Jelly \n" +
                    Padding);

                Console.WriteLine("Would You Like To Restart? Enter Yes or y To Continue. Or Press Any Other Key To Exit.");
                    RestartResponce = Console.ReadLine();

                //Restart Or Quit Program//
                if (RestartResponce == "Yes" || RestartResponce == "y" || RestartResponce == "yes" || RestartResponce == "Y")
                    { IsRestartRequired = false;
                    Console.Clear();
                } 
                else
                    { IsRestartRequired = true; } 

         }
        
        }
        Console.WriteLine("Goodbye!");
    }
}