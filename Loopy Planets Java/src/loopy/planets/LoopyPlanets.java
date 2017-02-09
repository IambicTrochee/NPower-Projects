/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package loopy.planets;

/**
 *
 * @author Sally
 */
//import Scanner to get user input
import java.util.Scanner;
public class LoopyPlanets {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // sets arrays for conversion rates and corresponding planet names
        double[] multiplierArray = {2.64, 0.38, 0.37, 1.12, 0.04, 1.15, 1.15, 0.88};
        String[] planetsArray = {"Jupiter", "Mars", "Mercury", "Neptune", "Pluto", "Saturn", "Uranus", "Venus"};
        
        //sets up scanner to get user input, declares variables for storing input
        Scanner userInput = new Scanner(System.in);
        int planetChoice = 0;
        double earthWeight = 0;
        
        //prints Menu to console
        System.out.println("          Menu of Planets\n          ==== == =======");
        System.out.println("1. Jupiter    2. Mars     3. Mercury\n4. Neptune    5. Pluto    6. Saturn\n7. Uranus     8. Venus    9. <Quit>\n");
        
       //starts loop until user chooses "9" for Quit
        while (planetChoice != 9) {
            
            try {
                //gets user input for planet and stores as integer
                System.out.print("Enter your menu choice: ");
                planetChoice = Integer.parseInt(userInput.next());                
                
                //breaks loop if user chooses "9" for Quit
                if (planetChoice == 9) {
                    System.out.println("Have a great day! Goodbye!");
                    break;
                }
                
                //checks that the menu selection is valid
                else if (1 > planetChoice || 9 < planetChoice) {
                    System.out.println("Please enter an integer from 1-9 to make your selection.");
                }
                
                else {
                    //loops until positive value is input
                    while (earthWeight <= 0) {
                        //gets and stores user input for weight
                        System.out.print("Enter your weight on earth: ");
                        earthWeight = Double.parseDouble(userInput.next());
                        
                        if (earthWeight < 0){
                            System.out.println("Please enter a positive value.");
                        }
                    }
                    
                    //calculates weight on selected planet
                    double newWeight = earthWeight;
                    newWeight *= multiplierArray[planetChoice - 1];

                    //matches planet selection to planet name
                    String planet = "";
                    planet = planetsArray[planetChoice - 1];

                    //prints converted weight on selected planet
                    System.out.println("\nYour weight of " + earthWeight + " pounds on Earth would be " + newWeight + " pounds on " + planet + ".");
                }
            }
            //catches non-convertible strings (eg. if user enters "Jupiter" instead of "1")
            catch (NumberFormatException e) {
                System.out.println("Please enter an integer between 1-9 for menu choice or a float for your weight on Earth.");
            }
        }
    }
    
}
