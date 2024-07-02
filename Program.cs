using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Console.ReadLine();

            //Insert a string at the start of another string
            string myCombinedString = myStringAsInt + myString;
            Console.WriteLine(myCombinedString);
            int answer = 1;

            //Main task
            string[] binaryNum = { "", "", "", "", "", "", "", "", "" };
            int denaryNum = 210;

            int i = 0;
            while (answer > -1)
            {
                answer = (denaryNum / 2);
                int remainder = denaryNum % 2;
                string stringRemainder = Convert.ToString(remainder);
                binaryNum[i] = Convert.ToString(remainder);
                i = i+2
            }
            Console.WriteLine(binaryNum);
            Console.ReadLine();
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
