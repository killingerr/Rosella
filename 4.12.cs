using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
     class Invoice
    {
        static void Main(string[] args)
        {
            int quantity = 0;
            double price = 0;
            
            // Invoice class object with required parameters
            InvoiceClass myInvoice = new InvoiceClass("item number","item description",quantity,price);

            

            Console.WriteLine("Enter quantity:");
            quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter price:");
            price = Convert.ToDouble(Console.ReadLine());
            
            myInvoice.GetInvoice(quantity, price);  // Class method used for calculating item price

        }
    }
}
