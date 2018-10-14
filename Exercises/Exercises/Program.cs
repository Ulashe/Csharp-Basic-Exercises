using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            "Program remove specified a character from a non-empty string using index of a character."

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
            Console.WriteLine();
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
            Console.WriteLine();
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
            Console.WriteLine(s.Remove(7,4));
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            bool t = true;

            while (t)
            {
                int x;
                Console.Write("+++Listeyi gormek icin 0 giriniz. Cikmak icin -1 giriniz\n+++İlgili soruyu gormek icin numarasını giriniz: ");
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
                }
            }
        }
    }
}
