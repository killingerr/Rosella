using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Grade 10/10 

namespace Assignment_6._22
{
    class Program
    {
        static void Main(string[] args)
        {
            
             for (int a = 1; a <= 500; a++)  // For loop for a
             {
                 for (int b = 1; b <= 500; b++)  // For loop for b
                 {
                     for (int c = 1; c <= 500; c++)  // For loop for c
                     {
                          if ((a*a)+ (b*b) == (c*c))  // Calculation for Pythagorean triples
                          {
                              Console.WriteLine("{0}, {1}, {2}", a, b, c); // Displays results
                                  
                       }// end of if statement
                    }//End for c
                 }//End for b
              }//End for a
           }//End Main
        }//End Class Program
     }//End Namespace
