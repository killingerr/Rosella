using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Grade 8.5/10
//Requirements state " inputs 5 numbers, each of which is between 10 and 100", your program is not validating the numbers
//Requirements state "as each number is read, display it only if it is not a duplicate of a number already read...", your program takes all 5 numbers and then does the display
//Program displays a blank line if a number is a duplicate, while this was not explicitly stated, there should not be a blank line.

namespace Assignment_8._12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int []array  = new int[5];

            Console.WriteLine("Enter five numbers between 10 and 100");
            for (int i = 0; i < array.Length; i++) //For loop for array
            {
                
                array[i] = Convert.ToInt32(Console.ReadLine());  //User input stored in array


                for (int k = 0; k < i; k++)  // For loop to test for duplicates
                {
                     if(array[k]==array[i])
                    {
                        array[i] =-1;
                    }
                    
                }//End K for loop

            }//End I for loop
        
                for(int j = 0; j<array.Length; j++) // For loop to display only non uplicate numbers
                {
                    if (array[j] == -1)
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("{0,5}", array[j]);  // Display values of the array
                    }
                }// End J for loop



                }// End main
        
        }//End class program
    }//End namspace

