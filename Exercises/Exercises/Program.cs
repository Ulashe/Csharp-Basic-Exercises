using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercises
{
    class Program
    {
        static void case0()
        {
            string[] questions = new string[] { "Program to print Hello and your name in a separate line.",
            "Program to print the sum of two numbers.",
            "Program to print the result of dividing two numbers.",
            "Program to print the result of the specified operations.",
            "Program to swap two numbers.",
            "Program to print the output of multiplication of three numbers which will be entered by the user.",
            "Program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.",
            "Program that takes a number as input and print its multiplication table.",
            "Program that takes four numbers as input to calculate and print the average.",
            "Program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.",
            "Program that takes an age (for example 20) as input and prints something as 'You look older than 20'.",
            "Program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation.",
            "Program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit.",
            "Program to convert from celsius degrees to Kelvin and Fahrenheit.",
            "Program remove specified a character from a non-empty string using index of a character.",
            "Program to create a new string from a given string where the first and last characters will change their positions.",
            "Program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.",
            "Program to check two given integers and return true if one is negative and one is positive.",
            "Program to compute the sum of two given integers, if two values are equal then return the triple of their sum.",
            "Program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than second number.",
            "Program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.",
            "Program to check if an given integer is within 20 of 100 or 200.",
            "Program to convert a given string into lowercase.",
            "Program to find the longest word in a string.",
            "Program to print the odd numbers from 1 to 99. Prints one number per line.",
            "Program to compute the sum of the first 500 prime numbers.",
            "Pogram and compute the sum of the digits of an integer.",
            "Program to reverse the words of a sentence.",
            "Program to find the size of a specified file in bytes. ",
            "Program to convert a hexadecimal number to decimal number.",
            "Program to multiply corresponding elements of two arrays of integers.",
            "Program to create a new string of four copies, taking last four characters from a given string. If the length of the given string is less than 4 return the original one.",
            "Program to check if a given positive number is a multiple of 3 or a multiple of 7.",
            "Program to check if a string starts with a specified word.",
            "Program to check two given numbers where one is less than 100 and other is greater than 200.",
            "Program to check if an integer (from the two given integers) is in the range -10 to 10.",
            "Program to check if 'HP' appears at second position in a string and returns the string without 'HP'.",
            "Program to get a new string of two characters from a given string. The first and second character of the given string must be 'P' and 'H', so PHP will be 'PH'.",
            "Program to find the largest and lowest values from three integer values.",
            "Program to check the nearest value of 20 of two given integers and return 0 if two numbers are same."

            };
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine((i+1) + "> " +questions[i]);
            }
            Console.WriteLine();
        }
        static void case1()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Ulas Ozturk\n");
        }
        static void case2()
        {
            int number1 = 5, number2 = 7;
            Console.WriteLine("The sum of {0} to {1} is: {2}\n", number1, number2, number1 + number2);
        }
        static void case3()
        {
            int number1 = 6, number2 = 2;
            Console.WriteLine("The result of {0} divided by {1} is: {2}\n", number1, number2, number1 / number2);
        }
        static void case4()
        {
            Console.WriteLine("4-7*3 : {0}",4-7*3);
            Console.WriteLine("(65-34)%6 : {0}",(65-34)%6);
            Console.WriteLine("23+11*3/6 : {0}",23+11*3/6);
            Console.WriteLine("19/3+20%6-5*8 : {0}",19/3+20%6-5*8);
        }
        static void case5()
        {
            Console.Write("Input number1: ");
            int x, y;
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number2: ");
            y = Convert.ToInt32(Console.ReadLine());
            int temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("The numbers changed. Number1: {0}, Number1: {1}",x,y);
        }
        static void case6()
        {
            int num1, num2, num3;
            Console.Write("Input number1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number3: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} * {1} * {2} : {3}",num1,num2,num3,num1*num2*num3);
            Console.WriteLine();
        }
        static void case7()
        {
            int num1, num2;
            Console.Write("Input number1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}\n{0} - {1} = {3}\n{0} x {1} = {4}\n{0} / {1} = {5}\n" +
                "{0} mod {1} = {6}\n",num1,num2,num1+num2,num1-num2,num1*num2,num1/num2,num1%num2);
        }
        static void case8() // Using string interpolation
        {
            int num;
            Console.Write("Input number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num*i}");
            }
            Console.WriteLine();
        }
        static void intput(ref int x)
        {
            x = Convert.ToInt32(Console.ReadLine());
        }
        static void intput(ref double x)
        {
            x = Convert.ToDouble(Console.ReadLine());
        }
        static void case9()
        {
            int n1=0, n2=0, n3=0, n4=0;
            Console.Write("First number: ");intput(ref n1);
            Console.Write("Second number: ");intput(ref n2);
            Console.Write("Third number: ");intput(ref n3);
            Console.Write("Fourth number: ");intput(ref n4);
            Console.WriteLine($"The average of {n1},{n2},{n3},{n4} is: {(double)(n1+n2+n3+n4)/4}\n");
        }
        static void case10()
        {
            int n1 = 0, n2 = 0, n3 = 0;
            Console.WriteLine("First number: ");intput(ref n1);
            Console.WriteLine("Second number: ");intput(ref n2);
            Console.WriteLine("Third number: ");intput(ref n3);
            Console.WriteLine($"({n1}+{n2})*{n3} is {(n1+n2)*n3} and {n1}*{n2}+{n2}*{n3} is {n1*n2+n2*n3}\n");
        }
        static void case11()
        {
            int age = 0;
            Console.Write("Enter your age: ");intput(ref age);
            Console.WriteLine($"You look older than {age}");
        }
        static void case12()
        {
            int n = 0;
            Console.Write("Enter an integer: ");intput(ref n);
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.Write(n);
                    if (i % 2 == 0) Console.Write(" "); 
                }
                Console.WriteLine();
            }
        }
        static void case13()
        {
            int n = 0; Console.Write("Enter a number: ");intput(ref n);
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (i != 0 && i != 4 && j == 1)
                    { Console.Write(" "); continue; }
                    Console.Write(n);
                }
                Console.WriteLine();
            }
        }
        static void case14()
        {
            double t = 0;
            Console.Write("Enter celcius: ");intput(ref t);
            Console.WriteLine($"Kelvin = {t + 273.15}");
            Console.WriteLine($"Fahrenheit = {t * 1.8 + 32}\n");
        }
        static void case15()
        {
            string s = "Visual Studio";
            Console.WriteLine(s);
            Console.WriteLine(s.Remove(2,2));
            Console.WriteLine(s.Remove(9,2));
        }
        static void case16()
        {
            string s = "Visual Studio";
            Console.WriteLine(s);
            string ss = s.Substring(s.Length - 1) + s.Substring(1, s.Length - 2) + s.Substring(0, 1);
            Console.WriteLine(ss);
        }
        static void case17()
        {
            Console.WriteLine("Input string: ");
            string s = Console.ReadLine();
            string ss = s.Substring(0, 1) + s + s.Substring(0, 1);
            Console.WriteLine(ss);
        }
        static void case18()
        {
            Console.WriteLine("Input two integer: ");
            int x = 0, y = 0;   intput(ref x);  intput(ref y);
            if ((x > 0 && y < 0) || (x < 0 && y > 0)) Console.WriteLine("True");
        }
        static void case19()
        {
            Console.WriteLine("Input two integer: ");
            int x = 0, y = 0;   intput(ref x);  intput(ref y);
            if (x == y)Console.WriteLine((x+y)*3);
            else Console.WriteLine(x+y);
        }
        static void case20()
        {
            Console.WriteLine("Input two integer: ");
            int x = 0, y = 0; intput(ref x); intput(ref y);
            if ((x - y) > 0) Console.WriteLine((x-y)*2);
            else Console.WriteLine(y-x);
        }
        static void case21()
        {
            Console.WriteLine("Input two integer: ");
            int x = 0, y = 0; intput(ref x); intput(ref y);
            if (x == 20 || y == 20 || (x + y) == 20) Console.WriteLine("True");
        }
        static void case22()
        {
            Console.WriteLine("Input integer: ");
            int x = 0;  intput(ref x);
            Console.WriteLine(ret(x));
            string ret(int a)
            {
                return ((a < 110 && a > 90) || (a < 210 && a > 190)) ? "True" : "False";
            }
        }
        static void case23()
        {
            Console.WriteLine("Input a string: ");
            string s = Console.ReadLine();
            Console.WriteLine(s.ToLower());
        }
        static void case24()
        {
            Console.WriteLine("Input a string: ");
            string s = Console.ReadLine();
            string[] arr = s.Split(' ');
            Console.WriteLine($"Longest word is {arr[bul(arr)]}");
            int bul(string[] ar){
                int j = 0, k = 0;
                for(int i = 0; i < ar.Length; i++)
                {
                    if (ar[i].Length > j)
                    {
                        k = i;
                        j = ar[i].Length;
                    }
                }
                return k;
            }
        }
        static void case25()
        {
            Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");
            for(int i = 0; i < 100; i++)
            {
                if(i%2==1)
                Console.WriteLine(i);
            }
        }
        static void case26()
        {
            for(int i = 2; i < 501; i++)
            {
                int t = 0;
                for(int j = i-1; j > 1; j--)
                {
                    if (i % j == 0) t = 1;
                }
                if (t == 0) Console.WriteLine(i);
            }
        }
        static void case27()
        {
            int num = 0, i = 0;
            Console.Write("Input a number: "); intput(ref num);
            while(num != 0)
            {
                i += num % 10;
                num /= 10;
            }
            Console.WriteLine($"Sum of the digits of the integer: {i}");
        }
        static void case28()
        {
            Console.Write("Original String: ");
            string s = Console.ReadLine();
            Console.Write("Reverse String: ");
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
            Console.WriteLine();
        }
        static void case29()
        {
            FileInfo file = new FileInfo("C:/Users/Ulaş/source/repos/Csharp-Basic-Exercises/Exercises/Exercises/Program.cs");
            Console.WriteLine($"Size of program.cs file: {file.Length.ToString()}");
        }
        static void case30()
        {
            string hex = "AB43F";
            Console.WriteLine("Hex value: {0}",hex);
            int deci = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("Decimal number: {0}",deci);
        }
        static void case31()
        {
            int[] x = { 1, 3, -5, 4 }, y = { 1, 4, -5, -2 };
            Console.WriteLine($"Array1: [{x[0]},{x[1]},{x[2]},{x[3]}]");
            Console.WriteLine($"Array2: [{y[0]},{y[1]},{y[2]},{y[3]}]");
            Console.WriteLine($"Array1 x Array2: [{x[0]*y[0]},{x[1]*y[1]},{x[2]*y[2]},{x[3]*y[3]}]");
        }
        static void case32()
        {
            Console.Write("Input a string: "); string s=Console.ReadLine();
            Console.WriteLine(s.Length < 4 ? s + s + s + s : s.Substring(s.Length-4) + s.Substring(s.Length - 4) + s.Substring(s.Length - 4) + s.Substring(s.Length - 4));
        }
        static void case33()
        {
            int num = 0; Console.WriteLine("Input an integer: "); intput(ref num);
            if (num % 3 == 0 || num % 7 == 0) Console.WriteLine("True");
        }
        static void Main(string[] args)
        {
            bool t = true;

            while (t)
            {
                int x;
                Console.Write("\n+++Listeyi gormek icin 0 giriniz. Cikmak icin -1 giriniz\n+++İlgili soruyu gormek icin numarasını giriniz: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (x)
                {
                    case -1:
                        t = false;
                        break;
                    case 0:
                        case0();
                        break;
                    case 1:
                        case1();
                        break;
                    case 2:
                        case2();
                        break;
                    case 3:
                        case3();
                        break;
                    case 4:
                        case4();
                        break;
                    case 5:
                        case5();
                        break;
                    case 6:
                        case6();
                        break;
                    case 7:
                        case7();
                        break;
                    case 8:
                        case8();
                        break;
                    case 9:
                        case9();
                        break;
                    case 10:
                        case10();
                        break;
                    case 11:
                        case11();
                        break;
                    case 12:
                        case12();
                        break;
                    case 13:
                        case13();
                        break;
                    case 14:
                        case14();
                        break;
                    case 15:
                        case15();
                        break;
                    case 16:
                        case16();
                        break;
                    case 17:
                        case17();
                        break;
                    case 18:
                        case18();
                        break;
                    case 19:
                        case19();
                        break;
                    case 20:
                        case20();
                        break;
                    case 21:
                        case21();
                        break;
                    case 22:
                        case22();
                        break;
                    case 23:
                        case23();
                        break;
                    case 24:
                        case24();
                        break;
                    case 25:
                        case25();
                        break;
                    case 26:
                        case26();
                        break;
                    case 27:
                        case27();
                        break;
                    case 28:
                        case28();
                        break;
                    case 29:
                        case29();
                        break;
                    case 30:
                        case30();
                        break;
                    case 31:
                        case31();
                        break;
                    case 32:
                        case32();
                        break;
                    case 33:
                        case33();
                        break;
                }
            }
        }
    }
}
