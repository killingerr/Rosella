using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
