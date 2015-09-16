using System;
namespace GradeBook
{
    public class GradeBook
    {

        public string CourseName { get; set; }       // Getters and Setters for course name and instructor name
        public string InstructorName { get; set; }   //


        public GradeBook(string cName, string iName)  // Constructor allowing two arguments
        {
            CourseName = cName;
            InstructorName = iName;

        }

        public void DisplayMessage()       // Display function 
        {
            Console.WriteLine("Welcome to: {0}", CourseName);
            Console.WriteLine("The instructor is: {0}", InstructorName);


        }

    }
}