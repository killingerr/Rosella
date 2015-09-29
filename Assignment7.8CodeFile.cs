using System;
namespace assignment_7._8
{
    public partial class Charges
    {
        
        public static void CalculateCharges()
        {
            double intCharges = 2.0;
            double userHours;
            double addCharges = 0.5;

            Console.WriteLine("How many hours did you park?");
            userHours = Convert.ToDouble(Console.ReadLine());


            if  (userHours <= 3)  // If statement for 3 hours or under parking time
            {
                Console.WriteLine("Your total is : ${0}",intCharges);  // Charge for parking time 3 hours or under

            }
            else if(userHours > 3 || userHours <= 24)  // If statement for charges over 3 hour parking time
            {
                double total = intCharges + (addCharges * userHours - 1.5);  // Calculations for parking charges greater than 3 hours
                
                if (total > 10)  // If statement maintaining a $10 maxium charge for 24 hour period
                {
                    total = 10;
                }
              
                Console.WriteLine("Your total is : ${0}", total);
            }
  
        }

    }









}