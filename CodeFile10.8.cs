using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class IntegerSet
{
    bool[] array1 = new bool[101];  // Array with 100 elements
    public IntegerSet()  // Constructor
    
    {
        for (int i = 0; i < array1.Length; i++ )  // Initializing all elements in array to false
        {
            array1[i] = false;
        }

    }
    
    public void InsertElement(int i)  // Inserts true into element
    {
        array1[i] = true;

    }

    public void DeleteElement(int i)  // Deletes true in element to make it false
    {
        array1[i] = false;


    }

    public override string ToString()  // ToString method used for dislaying dat within the array
    {
        string k = " ";

        for(int i = 0; i <= 100; i++)
        {
            if(this.array1[i] == true)
            {
                k += i + " ";
            }
            else
            {
                k += "___";
            }
        
        }
        return k;
    }
    
    public bool IsEqualTo(IntegerSet k)  // Method comparing two objects data within an array
    {
        for(int i = 0; i < array1.Length; i++)
        {
            if (k.array1[i] != array1[i])
            {
                return false;
            }
        }
        return true;
    }
       
    
}