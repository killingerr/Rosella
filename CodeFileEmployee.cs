using System;



public class Employee : Person  //Employee class derived from base class Person
{
    private string employeeID;
    private string department;
    

    public Employee (string first, string last, string addr, string phone, string id, string dept ) //Employee class constructor
        : base (first, last, addr, phone)  //Parent class constructor parameters
    {
        employeeID = id;
        department = dept;
    }

    public string Id
    {
        get
        {
            return employeeID;
        }
    }//End Id
    
    public string Dept
    {
        get
        {
            return department;
        }
    }//End Dept


    public override string ToString()  //Overridden ToString method 
    {

        return string.Format(
             "\n{0}: {1} {2}\n{3}: {4}\n{5}: {6} \n{7}{8} \n{9}{10}",
             "Person's full name", FirstName, LastName,
             "Address of person", Address,
             "Phone number", PhoneNumber,
             "Employee's ID number: ", employeeID,
             "Employee department: ", Dept);

    
    
    }//End ToString


}//End class