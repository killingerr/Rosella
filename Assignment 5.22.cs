using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int num = 1;
            int numMath_t= 10;
            int numMath_h = 100;
            int numMath_th = 1000;
          
            // While loop incrementing the value of num for each pass up to five
          while (num <= 5)
        {
                // calculations and display of num
              Console.WriteLine("N {0},{1},{2}", numMath_t * num, numMath_h * num, numMath_th * num );
              
              // Num incrementation
              num += 1;
            
            
              
        }
       
        
        
        
        }
    }
}
