﻿using System;


namespace GradeBook
{
    class GradeBookTest
    {
        static void Main(string[] args)
        {

            GradeBook myGradeBook = new GradeBook("C# 101", "Mr Tesla"); // Class object
            
            myGradeBook.DisplayMessage();   // Display function using constructor parameters
        }


    }
}

