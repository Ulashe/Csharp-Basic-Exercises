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
            "Program to check the nearest value of 20 of two given integers and return 0 if two numbers are same.",
            "Program to check if a given string contains ‘w’ character between 1 and 3 times.",
            "Program to create a new string where the first 4 characters will be in lower case. If the string is less than 4 characters then make the whole string in upper case.",
            "Program to check if a given string starts with \"w\" and immediately followed by two \"ww\".",
            "Program to create a new string of every other character (odd position) from the first position of a given string.",
            "Program to count a specified number in a given array of integers.",
            "Program to check if a number appears as either the first or last element of an array of integers and the length is 1 or more.",
            "Program to compute the sum of all the elements of an array of integers.",
            "Program to check if the first element and the last element are equal of an array of integers and the length is 1 or more.",
            "Program to check if the first element or the last element of the two arrays ( length 1 or more) are equal.",
            "Program to rotate an array (length 3) of integers in left direction.",
            "Program to get the larger value between first and last element of an array (length 3) of integers.",
            "Program to create a new array of length containing the middle elements of three arrays (each length 3) of integers.",
            "Program to check if an array contains an odd number.",
            "Program to get the century from a year.",
            "Program to find the pair of adjacent elements that has the largest product of an given array.",
            "Program to check if a given string is a palindrome or not.",
            "Program to find the pair of adjacent elements that has the highest product of an given array of integers.",
            "Program which will accept a list of integers and checks how many integers are needed to complete the range.",
            "Program to calculate the sum of all the intgers of a rectangular matrix except those integers which are located below an intger of value 0.",
            "Program to sort the integers in ascending order without moving the number -5.",
            "Program to reverse the strings contained in each pair of matching parentheses in a given string and also remove the parentheses within the given string."
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
        static void case34()
        {
            string data = Console.ReadLine();
            if (data.StartsWith("Hello") || data.StartsWith("hello"))
            {
                Console.WriteLine("Input starts with Hello");
            }
            else Console.WriteLine("Input does not start with Hello");
        }
        static void case35()
        {
            int num1 = 0; Console.WriteLine("Enter an integer less than 100: "); intput(ref num1);
            int num2 = 0; Console.WriteLine("Enter another integer greater than 100: "); intput(ref num2);
            if(num1 < 100 && num2 > 100)
            {
                Console.WriteLine("Inputs are right.");
            }
            else Console.WriteLine("Inputs are wrong.");
        }
        static void case36()
        {
            int num1 = 0; Console.WriteLine("Enter an integer: "); intput(ref num1);
            int num2 = 0; Console.WriteLine("Enter another integer: "); intput(ref num2);
            if(num1 > -10 && num1 < 10 && num2 > -10 && num2 < 10)
            {
                Console.WriteLine("Inputs are in the range -10 to 10.");
            }
            else Console.WriteLine("Input are not in the range -10 to 10.");
        }
        static void case37()
        {
            string data = "PHP Tutorial"; Console.WriteLine(data); Console.WriteLine();
            if(data.IndexOf("HP") == 1)
            {
                string data1 = data.Substring(0, 1);
                string data2 = data.Substring(3);
                Console.WriteLine(data1 + data2);
            }
            string str = "9HP 6676"; Console.WriteLine(str); Console.WriteLine(); Console.WriteLine();
            if (str.IndexOf("HP") == 1)
            {
                string data1 = str.Substring(0, 1);
                string data2 = str.Substring(3);
                Console.WriteLine(data1 + data2);
            }
        }
        static void case38()
        {
            string str = "PHP Tutorial"; Console.WriteLine(str + "\n"); 
            if (str[0] == 'P' && str[1] == 'H')
            {
                var result = "";  // Ancak bu şekilde olabildi.
                result += str[0];
                result += str[1];
                Console.WriteLine(result);
            }
        }
        static void case39()
        {
            int num1 = 0; Console.WriteLine("Enter first integer: "); intput(ref num1);
            int num2 = 0; Console.WriteLine("Enter second integer: "); intput(ref num2);
            int num3 = 0; Console.WriteLine("Enter third integer: "); intput(ref num3);
            Console.WriteLine();
            // -----------------------------
            // Hazır fonksiyonlar ile yapımı
            // -----------------------------

            Console.WriteLine("Largest of three: " + Math.Max(num1, Math.Max(num2,num3)));
            Console.WriteLine("Lowest of three: " + Math.Min(num1, Math.Min(num2,num3)));
            Console.WriteLine("\n-----------------\n");

            // ------------------------------
            // Kendi yazdığım şekliyle
            // ------------------------------

            if(num1 > num2)
            {
                if(num1 > num3)
                {
                    Console.WriteLine("Largest of three: {0}", num1);
                    if (num2 > num3) Console.WriteLine("Lowest of three: {0}",num3);
                    else Console.WriteLine("Lowest of three: {0}", num2);
                }
                if(num3 > num1)
                {
                    Console.WriteLine("Largest of three: {0}", num3);
                    Console.WriteLine("Lowest of three: {0}",num2);
                }
            }
            if(num2 > num1)
            {
                if(num2 > num3)
                {
                    Console.WriteLine("Largest of three: {0}",num2);
                    if (num3 > num1) Console.WriteLine("Lowest of three: {0}",num1);
                    else Console.WriteLine("Lowest of three: {0}",num3);
                }
                if(num3 > num2)
                {
                    Console.WriteLine("Largest of three: {0}",num3);
                    Console.WriteLine("Lowest of three: {0}", num1);
                }
            }

            // ------------------------------
            // Daha verimli bir çözüm.
            // ------------------------------

            Console.WriteLine("\n-----------------\n");

            int max = num1;
            int min = num1;

            if (num2 > max) max = num2;
            if (num3 > max) max = num3;

            if (num2 < min) min = num2;
            if (num3 < min) min = num3;

            Console.WriteLine("Largest of three: {0}\nLowest of three: {1}", max, min);
        }
        static void case40()
        {
            int num1 = 0; Console.WriteLine("Enter an integer: "); intput(ref num1);
            int num2 = 0; Console.WriteLine("Enter another integer: "); intput(ref num2);
            if (Math.Abs(20 - num1) < Math.Abs(20 - num2)) Console.WriteLine("{0} is closer", num1);
            else Console.WriteLine("{0} is closer", num2);
        }
        static void case41()
        {
            Console.WriteLine("Enter a string contains at least one 'w' character between 1 and 3 times");
            string str = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'w') count++;
            }
            if (count >= 1 && count <= 3) Console.WriteLine(true);
            else Console.WriteLine(false);
        }
        static void case42()
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            if (str.Length < 4) Console.WriteLine(str.ToUpper());
            else Console.WriteLine(str.ToLower());
        }
        static void case43()
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            Console.WriteLine(str.StartsWith("www"));
        }
        static void case44()
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            string str2= "";
            for (int i = 0; i < str.Length; i+=2)
            {
                str2 += str[i];
            }
            Console.WriteLine(str2);
        }
        static void case45()
        {
            int[] nums = { 2, 4, 6, 4, 3, 8, 10, 45, 34, 23, 1, 5, 41, 332, 45 };
            foreach (var item in nums)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\n Enter an integer: "); int num = 0; intput(ref num);
            int count = 0;
            foreach (var item in nums)
            {
                if (item == num) count++;
            }
            Console.WriteLine($"Number of {num} present in the said array: {count}\n");
            Console.WriteLine($"Number of {num} present in the said array: {nums.Count(n => n == num)}");
        }
        static void case46()
        {
            int[] nums = { 2, 3, 5, 3, 7, 5, 3, 8, 4, 3, 4, };
            foreach (var item in nums)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\nEnter an integer: "); int num = 0; intput(ref num);
            Console.WriteLine(num == nums[0] || num == nums[nums.Length-1]);
        }
        static void case47()
        {
            int[] nums = { 2, 3, 5, 3, 7, 5, 3, 8, 4, 3, 4, 6};
            foreach (var item in nums)
            {
                Console.Write(item + ", ");
            }
            int num = 0;
            foreach (var item in nums)
            {
                num += item;
            }
            Console.WriteLine("\nSum of the elements in the array: {0}", num);
        }
        static void case48()
        {
            int[] nums = { 2, 3, 5, 3, 7, 5, 3, 8, 4, 3, 4, 6 };
            foreach (var item in nums)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine(nums[0] == nums[nums.Length-1]);
            int num = 0; Console.WriteLine("Enter an integer for change the last number: "); intput(ref num);
            nums[nums.Length - 1] = num;
            foreach (var item in nums)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine(nums[0] == nums[nums.Length - 1]);
        }
        static void case49()
        {
            int[] nums1 = { 1, 3, 4, 5, 7, 2, 5, 7, 4, 5, 3, 6 };
            Console.WriteLine("Array1: {0}\n", string.Join(", ", nums1));
            int[] nums2 = { 1, 4, 5, 6, 7, 4, 3, 5, 6, 4, 2, 3 };
            Console.WriteLine($"Array2: {string.Join(", ", nums2)}\n\n");
            Console.WriteLine(nums1[0].Equals(nums2[0]) || nums1[nums1.Length-1] == nums2[nums2.Length-1]);
        }
        static void case50()
        {
            int[] nums = { 2, 5, 4 };
            Console.WriteLine(string.Join(", ",nums));
            
            for (int i = 0; i < nums.Length / 2; i++)  // Burada kritik bir hata yaptım
            {                                          // Dizinin ortasına kadar gitmek lazım. yoksa her şeyi geri almış oluyorsun.
                int temp = nums[i];
                nums[i] = nums[nums.Length -1 - i];
                nums[nums.Length -1- i] = temp;
            }
            Console.WriteLine("\nArray rotated\n");
            Console.WriteLine(string.Join(", ", nums));
        }
        static void case51()
        {
            int[] nums = { 2, 3, 5, 6, 7, 8, 6, 9 };
            Console.WriteLine(string.Join(", ", nums));
            int max = nums[1];
            for (int i = 2; i < nums.Length-1; i++)
            {
                if (nums[i] > max) max = nums[i];
            }
            Console.WriteLine("Max value between first and last values: {0}", max);
        }
        static void case52()
        {
            int[] n1 = { 1, 2, 3 };
            Console.WriteLine(string.Join(", ", n1));
            int[] n2 = { 4, 5, 6 };
            Console.WriteLine(string.Join(", ", n2));
            int[] n3 = { 7, 8, 9 };
            Console.WriteLine(string.Join(", ", n3));
            int[] nums = { n1[1], n2[1], n3[1] };
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", nums));
        }
        static void case53()
        {
            int[] nums = { 2, 4, 5, 6, 8, 6, 0 };
            Console.WriteLine(string.Join(", ",nums));
            bool b = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 1) b = true;
            }
            Console.WriteLine(b);
        }
        static void case54()
        {
            int year = 0; Console.WriteLine("Enter the year: "); intput(ref year);
            var date = new DateTime(year,1,1);
            Console.WriteLine(date.Year);
        }
        static void case55()
        {
            int[] nums = { 21, 33, 44, 51, 53, 43, 13, 25, 38, 45, 63, 76, 34, 44, 32, 41 };
            int max = 0;
            Console.WriteLine(string.Join(", ",nums));
            foreach (var item in nums)
            {
                if (item > max) max = item;
            }
            int i = Array.IndexOf(nums, max);
            Console.WriteLine(nums[i-1]+", "+nums[i]+", "+nums[i+1]);
        }
        static void case56()
        {
            string str = Console.ReadLine();
            bool b = true;
            for (int i = 0; i < str.Length/2; i++) // ey nihat adanada tahin ye
            {
                if (str[i] != str[str.Length -1 - i]) b = false;
            }
            Console.WriteLine(b);
        }
        static void case57()
        {
            int[] nums = { 12, 4, 6, 10, 8, 9, 15, 16 };
            Console.WriteLine(string.Join(", ", nums));
            int max = 0;
            int index = 0;
            for (int i = 0; i < nums.Length-1; i++)
            {
                if(nums[i]*nums[i+1] > max)
                {
                    max = nums[i] * nums[i + 1];
                    index = i;
                }
            }
            Console.WriteLine($"The highest product is {max} whic was from pairs {nums[index]},{nums[index+1]}");
        }
        static void case58()
        {
            int[] nums = { 4, 3, 6, 7, 9 };
            Console.WriteLine(string.Join(", ",nums));
            bool b = false;
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                b = false;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == nums[j]) b = true;
                }
                if (b == false) count++;
            }
            Console.WriteLine("Need {0} integer.",count);
        }
        static void case59()
        {
            int[,] nums = { { 0, 2, 3, 2 }, { 0, 6, 0, 1 }, { 4, 0, 3, 0 } };
            int sum = 0;
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write(nums[i,j] + " , ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    sum += nums[i, j];
                    
                    if(nums[i, j] == 0 && i < nums.GetLength(0)-1)
                    {
                        nums[i+1, j] = 0;
                    }
                }
            }
            Console.WriteLine(sum);
        }
        static void case60()
        {
            int[] nums = { -5, 236, 120, 70, -5, -5, 698, 280 };
            Console.WriteLine(string.Join(", ", nums));
            Console.WriteLine("-----------------------------------");
            for (int k = 0; k < nums.Length-1; k++)
            {
                for (int i = 0; i < nums.Length-1; i++)
                {
                    if (nums[i] != -5)
                    {
                        if (nums[i + 1] != -5)
                        {
                            if(nums[i] > nums[i + 1])
                            {
                                int temp = nums[i+1];
                                nums[i + 1] = nums[i];
                                nums[i] = temp;

                            }
                        }
                        if(nums[i + 1] == -5)
                        {
                            int j;
                            for (j = 2; j < nums.Length; j++)
                            {
                                if(nums[i + j] != -5)
                                {
                                    break;
                                }
                            }
                            if(nums[i] > nums[i + j])
                            {
                                int temp = nums[i + j];
                                nums[i + j] = nums[i];
                                nums[i] = temp;
                            }
                        }
                    }
                }
                    Console.WriteLine(string.Join(", ", nums));
                //Console.WriteLine("-----------");
            }
            //Console.WriteLine(string.Join(", ", nums));
        }
        static void case61()
        {
            string str = "ab(cd(e(asdf)f)gh)ij";
            string result = "";
            result = str3(str);
            Console.WriteLine(result);
        }
        static string str3(string str)
        {
            int left = str.LastIndexOf('(');
            if (left == -1)
            { return str; }
            else
            {
                int right = str.IndexOf(')', left);
                string str5= "";

                str5 += str.Substring(0, left);
                str5 += new string(str.Substring(left + 1, right - left - 1).Reverse().ToArray());
                str5 += str.Substring(right + 1);

                return str3(str5);
            }
        }
        static void Main(string[] args)
        {
            bool t = true;
            while (t)
            {
                int x;
                Console.Write("\n+++Listeyi gormek icin 0 giriniz. Cikmak icin -1 giriniz\n+++İlgili soruyu gormek icin numarasını giriniz: ");
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    switch (x)
                    {
                        case -1: t = false;break;
                        case 0: case0();break;
                        case 1: case1();break;
                        case 2: case2();break;
                        case 3: case3();break;
                        case 4: case4();break;
                        case 5: case5();break;
                        case 6: case6();break;
                        case 7: case7();break;
                        case 8: case8();break;
                        case 9: case9();break;
                        case 10: case10();break;
                        case 11: case11();break;
                        case 12: case12();break;
                        case 13: case13();break;
                        case 14: case14();break;
                        case 15: case15();break;
                        case 16: case16();break;
                        case 17: case17();break;
                        case 18: case18();break;
                        case 19: case19();break;
                        case 20: case20();break;
                        case 21: case21();break;
                        case 22: case22();break;
                        case 23: case23();break;
                        case 24: case24();break;
                        case 25: case25();break;
                        case 26: case26();break;
                        case 27: case27();break;
                        case 28: case28();break;
                        case 29: case29();break;
                        case 30: case30();break;
                        case 31: case31();break;
                        case 32: case32();break;
                        case 33: case33();break;
                        case 34: case34();break;
                        case 35: case35();break;
                        case 36: case36();break;
                        case 37: case37();break;
                        case 38: case38();break;
                        case 39: case39();break;
                        case 40: case40();break;
                        case 41: case41();break;
                        case 42: case42();break;
                        case 43: case43();break;
                        case 44: case44();break;
                        case 45: case45();break;
                        case 46: case46();break;
                        case 47: case47();break;
                        case 48: case48();break;
                        case 49: case49();break;
                        case 50: case50();break;
                        case 51: case51();break;
                        case 52: case52();break;
                        case 53: case53();break;
                        case 54: case54();break;
                        case 55: case55();break;
                        case 56: case56();break;
                        case 57: case57();break;
                        case 58: case58();break;
                        case 59: case59();break;
                        case 60: case60();break;
                        case 61: case61(); break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("\n-1, 0 ve pozitif tamsayilar giriniz\n\n");
                    Console.WriteLine(e);
                }
            }
        }
    }
}
