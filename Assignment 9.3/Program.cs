using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initalized array
            Invoice[] partInvoice =  {new Invoice (67,"Electric Sander",7,29.67M),
                                      new Invoice (23,"Popwer Saw", 5,36.76M),
                                      new Invoice (2,"Sledge Hammer", 7, 19.99M),
                                      new Invoice (44,"Hammer", 76, 10.50M),
                                      new Invoice (23,"Lawn Mower", 4, 189.99M),
                                      new Invoice (12,"Jig Saw", 7, 23.59M)
                                      };



            Console.WriteLine("Part list:\n");
            
            //Loops through and displays array
            foreach (var element in partInvoice)
            {
                Console.WriteLine(element);
            }

            //Variable for sorting by part description
            var partD =
                from i in partInvoice
                orderby i.PartDescription
                select i;

            
            Console.WriteLine("\nPart description list:\n");
            
            //Loop through array and display only part description
            foreach(var invoice in partD)
            {
                Console.WriteLine(invoice.PartDescription);

            }


            //Variable sorting by price
            var partPrice =
                from i in partInvoice
                orderby i.Price
                select i;

            Console.WriteLine("\nPart price list:\n");
            
            //Loops through and displays prices for each item
            foreach (var invoice in partPrice)
            {
                Console.WriteLine(invoice.Price);

            }

            //Variable for sorting only part description and quantities
            var partDQ =
               from i in partInvoice
               orderby i.PartDescription, i.Quantity
               select i;

            Console.WriteLine("\nPart Quantity| Part Description");
            
            //Loop through and displays only quantities and part descriptions
            foreach (var invoice in partDQ)
            {
                string data = invoice.Quantity + "              " + invoice.PartDescription;
                Console.WriteLine(data);

            }

            //Variable calculating totals of each item
            var truePrice =
                from i in partInvoice
                let total = (i.Quantity * i.Price)
                select new { i.PartDescription, total };

            Console.WriteLine("\nPrice                       Total");
            
            //Loop for displaying each items part description and total calculated
            foreach(var invoice in truePrice)
            {
                string totalC = invoice.PartDescription + "             " + invoice.total;
                Console.WriteLine(invoice);
            }

            //Variable for sorting by price range between $200 and $500
            var priceRange =
                from i in partInvoice
                let total = (i.Quantity * i.Price)
                where total >= 200m && total <= 500m
                select i;

            Console.WriteLine("\nItems between $200 and $500:");

            //Loop for sorting through and displaying only items with a price range between $200 and $500
            foreach(var invoice in priceRange)
            {
                Console.WriteLine("{0}",invoice);

            }

            
        
        
        
        
        
        }
    }
}
