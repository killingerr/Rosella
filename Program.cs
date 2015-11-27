using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class objects creation from base and derived classes
            Person myPerson = new Person("Tony", "Rosella" ,"123 way St.", "444-5555");
            Student myStudent = new Student("Joe", "Bob", "321 North Ave.", "321-123-4567", 3.45, "Computer Science", "11/10/16");
            Employee myEmployee = new Employee("Jake", "Smith", "456 Sea Dr.", "321-867-5309", "42345", "Health");
            Instructor myInstructor = new Instructor("Shela", "Roberts", "323 Fruit way", "323-456-3412", "333", "8-4 pm");
            
            //Displays info for each class 
            Console.WriteLine(myPerson);
            Console.WriteLine(myStudent);
            Console.WriteLine(myEmployee);
            Console.WriteLine(myInstructor);
    
        }

    }
}
