using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopy_Planets_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // sets variables for conversion rates
            double mercuryMultiplier = 0.37;
            double venusMultiplier = 0.88;
            double marsMultiplier = 0.38;
            double jupiterMultiplier = 2.64;
            double saturnMultiplier = 1.15;
            double uranusMultiplier = 1.15;
            double neptuneMultiplier = 1.12;
            double plutoMultiplier = 0.04;

            //declares variables for storing input
            int planetChoice = 0;
            double earthWeight = 0;

            //prints Menu to console
            Console.WriteLine("          Menu of Planets\n          ==== == =======");
            Console.WriteLine("1. Jupiter    2. Mars     3. Mercury\n4. Neptune    5. Pluto    6. Saturn\n7. Uranus     8. Venus    9. <Quit>\n");

            //starts loop until user chooses "9" for Quit
            while (planetChoice != 9)
            {

                try
                {
                    //gets user input for planet and stores as integer
                    Console.Write("Enter your menu choice: ");
                    planetChoice = Int32.Parse(Console.ReadLine());

                    //breaks loop if user chooses "9" for Quit
                    if (planetChoice == 9)
                    {
                        Console.WriteLine("Have a great day! Goodbye!");
                        Console.ReadLine();
                        break;
                    }

                    //checks that the menu selection is valid
                    else if (1 > planetChoice || 9 < planetChoice)
                    {
                        Console.WriteLine("Please enter an integer from 1-9 to make your selection.");
                    }

                    else
                    {
                        //loops until a positive value is input
                        while (earthWeight <= 0)
                        {
                            //gets and stores user input for weight
                            Console.Write("Enter your weight on earth: ");
                            earthWeight = Double.Parse(Console.ReadLine());

                            if (earthWeight < 0)
                            {
                                Console.WriteLine("Please enter a positive value for weight.");
                            }
                        }
                        //converts stored weight string to a float and calculates weight on selected planet
                        double newWeight = Math.Abs(earthWeight);
                        switch (planetChoice)
                        {
                            case 1:
                                newWeight *= jupiterMultiplier;
                                break;
                            case 2:
                                newWeight *= marsMultiplier;
                                break;
                            case 3:
                                newWeight *= mercuryMultiplier;
                                break;
                            case 4:
                                newWeight *= neptuneMultiplier;
                                break;
                            case 5:
                                newWeight *= plutoMultiplier;
                                break;
                            case 6:
                                newWeight *= saturnMultiplier;
                                break;
                            case 7:
                                newWeight *= uranusMultiplier;
                                break;
                            case 8:
                                newWeight *= venusMultiplier;
                                break;
                        }

                        //matches planet selection to planet name
                        String planet = "";
                        switch (planetChoice)
                        {
                            case 1:
                                planet = "Jupiter";
                                break;
                            case 2:
                                planet = "Mars";
                                break;
                            case 3:
                                planet = "Mercury";
                                break;
                            case 4:
                                planet = "Neptune";
                                break;
                            case 5:
                                planet = "Pluto";
                                break;
                            case 6:
                                planet = "Saturn";
                                break;
                            case 7:
                                planet = "Uranus";
                                break;
                            case 8:
                                planet = "Venus";
                                break;
                        }

                        //prints converted weight
                        Console.WriteLine("\nYour weight of " + earthWeight + " pounds on Earth would be " + newWeight.ToString("0.0") + " pounds on " + planet + ".");
                    }
                }
                //catches non-convertible strings (eg. if user enters "Jupiter" instead of "1")
                catch (System.FormatException e1)
                {
                    Console.WriteLine("Please enter an integer between 1-9 for menu choice or a positive float for your weight on Earth.");
                }
                catch (System.OverflowException e2)
                {
                    Console.WriteLine("Please enter an integer between 1-9 for menu choice or a positive float for your weight on Earth.");
                }
            }
        }
    }
}
