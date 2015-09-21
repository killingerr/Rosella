using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Grade: 9/10 Height should be taken in inches to allow for heights such as 5' 5" - this would be entered as 65 inches. No comments. 
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            double bodyW;
            double bodyH;

            Console.Write("Enter your weight(In pounds): ");
            bodyW = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your height(In feet): ");
            bodyH = Convert.ToDouble(Console.ReadLine());

            double bmi = (bodyW * 703) / ((bodyH * 12) * (bodyH * 12));

            Console.Write("\nYour body mass index is: {0}", (bmi.ToString("#.#")));
            Console.Write("\nUnderweight: less that 18.5");
            Console.Write("\nNormal weight: Between 18.5 - 24.9");
            Console.Write("\nOverweight: 25 - 29.9");
            Console.Write("\nObese: 30 or greater");

            Console.Read();


        }
    }
}
