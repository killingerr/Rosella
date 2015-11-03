using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10._8
{
    class Program
    {

    public class IntegerSet2 : IntegerSet        // Derived lass from the parent class Integer set
    {
         

    
        static void Main(string[] args)
        {
            IntegerSet2 iSet = new IntegerSet2();  // Initialized object using derived class
            IntegerSet2 iSet2 = new IntegerSet2();  // Initialized object using derived class

             iSet.InsertElement(56);  // Object of derived with data inserted from method
             iSet2.InsertElement(24); // Object of derived with data inserted from method
             
             Console.WriteLine(iSet.ToString());  // Display current data of object
             Console.WriteLine(iSet2.ToString()); // Display current data of object
            
             iSet.DeleteElement(56);  // Object of derived with data deleted using method
             iSet2.DeleteElement(24);  // Object of derived with data deleted using method

             Console.WriteLine(iSet.ToString()); // Display current data of object
             Console.WriteLine(iSet2.ToString()); // Display current data of object
             
             iSet.IsEqualTo(iSet2);  // Method comparing iSet object to iSet2 object
             
        }
    }
    }
}
