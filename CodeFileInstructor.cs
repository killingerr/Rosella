using System;



public class Instructor : Person //Instructor class derived from base class Person
{
    private string officeNumber;
    private string officeHours;


    public Instructor(string first, string last, string addr, string phone, string officeNum, string hours) //Instructor class constructor
        : base(first, last, addr, phone)  //Base class constructor parameters
    {
        officeNumber = officeNum;
        officeHours = hours;
    }

    public string OfficeNumber
    {
        get
        {
            return officeNumber;
        }
    }//End OfficeNumber

    public string OfficeHours
    {
        get
        {
            return officeHours;
        }
    }//End OfficeHours


    public override string ToString()  //Overridden ToString method 
    {

        return string.Format(
             "\n{0}: {1} {2}\n{3}: {4}\n{5}: {6} \n{7}{8} \n{9}{10}",
             "Person's full name", FirstName, LastName,
             "Address of person", Address,
             "Phone number", PhoneNumber,
             "Instructo's office number: ", OfficeNumber,
             "Instructor's office hours: ", OfficeHours);



    }//End ToString
}//End class