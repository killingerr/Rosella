using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Extra Credit: 3 points
//Missing Requirements:
//Provide a property with a get and set accessor for any instance variables
//For quantity and price per item, If the value passed to the set accessor is negative the instance variables should be left unchanged
//Create a method GetInvoiceAmount that should return the amount - your method does not return the value, it just writes it to the console
namespace Assignment
{
    public class InvoiceClass
    {
        public string partNum { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }

        

        public InvoiceClass(string ipartNum, string iDescription, int iQuantity, double iPrice) //Class constructor
        {
            partNum = ipartNum;
            description = iDescription;
            quantity = iQuantity;
            price = iPrice;

        }
        public void GetInvoice(int quantity, double price)  // Method for calculating item price
        {
            double total;

            double dtotal = Convert.ToDouble(quantity);
            total = dtotal * price;
            Console.WriteLine("Your total is: {0}", total);

        }


    }
}
