using System;

//Grade 8/10 -Missing Requirements:
//  1. Enter the hours for EACH customer in the garage yesterday and display the total charge for the CURRENT customer  Your program can only calculate the charges for one customer.
//  2. Display a RUNNING total of yesterday's receipts
//  3. Customer should be charged .50/hour for each additional hour or each PART THEREOF.  This means that the hours need to be rounded up so that if a customer parked for 5.5 hours, they would be charged for 6.

namespace assignment_7._8
{
    public partial class Charges
    {


        static void Main(string[] args)
        {

            Charges.CalculateCharges();  // Calculation charges function

        }
    }
}
