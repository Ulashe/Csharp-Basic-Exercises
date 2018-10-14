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
            string[] questions = new string[] { "Write a C# Sharp program to print Hello and your name in a separate line.",
            "Write a C# Sharp program to print the sum of two numbers.",
            "Write a C# Sharp program to print the result of dividing two numbers.",
            "Write a C# Sharp program to print the result of the specified operations.",
            "Write a C# Sharp program to swap two numbers.",
            "Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user."};
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
                }
            }
        }
    }
}
