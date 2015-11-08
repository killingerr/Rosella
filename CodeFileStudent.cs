using System;



public class Student : Person  //Student class derived from base class Person
{
    private double gradePoint;
    private string majorDegree;
    private string graduationDate;

    public Student (string first, string last, string addr, string phone, double gpa, string major, string grad ) //Student class constructor
        : base (first, last, addr, phone)  //Parent class constructor parameters
    {
        gradePoint = gpa;
        majorDegree = major;
        graduationDate = grad;
    }

    public double Gpa
    {
        get
        {
            return gradePoint;
        }
    }//End Gpa
    
    public string MajorDegree
    {
        get
        {
            return majorDegree;
        }
    }//End MajorDegree

    public string GraduationDate
    {
        get
        {
            return graduationDate;
        }
    }//End GraduationDate

    public override string ToString()  //Overridden ToString method 
    {

        return string.Format(
             "\n{0}: {1} {2}\n{3}: {4}\n{5}: {6} \n{7}{8} \n{9}{10} \n{11}{12}",
             "Person's full name", FirstName, LastName,
             "Address of person", Address,
             "Phone number", PhoneNumber,
             "Student's GPA: ", Gpa,
             "Student's Major: ", MajorDegree,
             "Student's graduation date:", GraduationDate);



    }//End ToString


}//End class