using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Grade 9.5/10
namespace _8._17
{
    class Dice
    {
        private static Random randomNum = new Random();
        
            static void Main(string[] args)
        {
            int face1 = 0;
            int face2 = 0;
            
            int[] dArray = new int[13];  // Array declaration and initialization

            //The program should roll the dice 36,000 times, you are looping from 1 to roll < 36,000 which will roll the dice 35,999
            for (int roll = 1; roll < 36000; roll++)
            {
                face1 = randomNum.Next(1, 7);  // Random roll for dice 1
                face2 = randomNum.Next(1, 7);  // Random rool for dice 2
                int sum = face1 + face2;
                dArray[sum]++;                 // Increments indices  with the sum of the dice rolls

                

            } //End for loop

                Console.WriteLine("{0}{1,10}", "dice sum", "      frequency");

                for (int face = 2; face < dArray.Length; face++)  // Loop for sum frequency
                {

                    Console.WriteLine("{0,7}{1,10}", face, dArray[face]); // Displays all possible sums and frequencies
                
                }//End for loop
            
        }//End main
    }
}
