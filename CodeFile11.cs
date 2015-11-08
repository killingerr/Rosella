using System;


    public class Person  //Base class
    {
        private string firstName;
        private string lastName;
        private string address;
        private string phoneNumber;

        public Person(string first, string last, string addr, string phone) //Constructor
        {
            firstName = first;
            lastName = last;
            address = addr;
            phoneNumber = phone;

        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }//End FirstName

        public string LastName
        {
            get
            {
                return lastName;
            }
        }//End LastName

        public string Address
        {
            get
            {
                return address;
            }
        }//End Address

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
        }//End PhoneNumber

        public override string ToString()  //Overridden ToString method 
        {
            return string.Format(
            "{0}: {1} {2}\n{3}: {4}\n{5}: {6}",
            "Person's full name", FirstName, LastName,
            "Adrress of person", Address,
            "Phone number", PhoneNumber);


        }//End ToString
    }//End class
