using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Grade 9.5/10 - Make sure you are formatting your code correctly.  It should be very clear to me where a code block
//               begins and ends.  I should be able to visually match the open and closed braces.

namespace Assignment_7._30
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNum = new Random();  //Random number generator
            
            int answer;
            int userAnswer;
            char pAgain;
         
//-------------------------------------------------------------------------------------------------------//     
            
          do                                    // Do loop to allow multiple play throughs
          {
            answer = randomNum.Next(0, 1000);  // Intializing answer with random number withing 1-1000 range
            
            Console.WriteLine("Guess the number:");
            userAnswer = Convert.ToInt32(Console.ReadLine());

            
                while (userAnswer != answer)                      // While loop to allow user to guess correct number
                {

                    if (userAnswer < answer)                      //  If statement if the user answer is lees than the random number
                    {
                        Console.WriteLine("You must guess higher, try again");
                    }
                    if (userAnswer > answer)                      // If statement if the user answer is greater than the random number
                    {
                        Console.WriteLine("You must guess lower, try again");
                    }
                    Console.WriteLine("Guess the number:");
                    userAnswer = Convert.ToInt32(Console.ReadLine());
                    }                                              // End of while loop
              
                    
                 if (userAnswer == answer)                         // If statement when user guesses correct number
                    {
                    Console.WriteLine("You've guessed correctly!");
                    }
                    Console.WriteLine("Would you like to play again?\n press y for yes or any other key for no");
                    pAgain = Convert.ToChar(Console.ReadLine());
                    }                                                   // End of do loop
                
                while (pAgain == 'y');          // Condition to loop again through do loop
               
            
            
        } // End of Main
    } // End of Class
} // End of Namespace
