﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            //STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode)
            int myInt = 0; //just for testing single stepping
            string myString = "12"; //watch me being cast from string to int
            int myStringAsInt = Convert.ToInt32(myString);

            //Convert integer to string
            string myIntAsString = Convert.ToString(myInt);
            Console.WriteLine(myIntAsString);

            //Insert a string at the start of another string
            string myCombinedString = myStringAsInt + myString;
            Console.WriteLine(myCombinedString);
            int answer = 1;

            //Main task
            Console.WriteLine("Enter number");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int remainder = userNum % 2;

            int (i = 0)
            while (i = 0) ;
            {
                Console.WriteLine(remainder);
            }
            Console.WriteLine(remainder);
            //string stringRemainder = Convert.ToString(remainder);
            //string userStringNum = Convert.ToString(userNum);
            ////userStringNum[i] = Convert.ToString(remainder);
            //i = i + 1;

            //Console.WriteLine(binaryNum);
            //Console.ReadLine();
        }

    }
}
//} //watch me cast from string to int

//            //MAIN:  NUMBER CONVERSION PROGRAM
           

//            //CODE GOES HERE
//        }

//        //static void means the function will not return a value so it does not need a data type 
//        //...this function DOES return a value so the method must have a data type
//        static string numberConversion(int number, int numberbase)
//{
//    //CODE GOES HERE

//    return result; //REMOVE THE RED LINE!
//}
//    }
//}
