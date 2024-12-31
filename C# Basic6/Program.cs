using System;

namespace C__Basic6
{
    internal class Program
    {
        #region Function Q1
        //static void PassByValue(int x)
        //{
        //    x = 10;
        //    Console.WriteLine("Inside method: " + x);
        //}

        //static void PassByReference(ref int x)
        //{
        //    x = 10;
        //    Console.WriteLine("Inside method: " + x);
        //}
        #endregion

        #region Function Q2

        //static int SumNum(int number)
        //{
        //    int sum = 0;
        //    while (number > 0)
        //    {
        //        sum += number % 10;
        //        number /= 10;
        //    }
        //    return sum;

        //}


        #endregion

        #region Function Q3
        //public static bool IsPrime(int number)
        //{

        //    if (number <= 1) return false;
        //    if (number == 2) return true; 
        //    if (number % 2 == 0) return false; 


        //    for (int i = 3; i * i <= number; i += 2)
        //    {
        //        if (number % i == 0)
        //        {
        //            return false; 
        //        }
        //    }

        //    return true; 
        //}
        #endregion

        #region Function Q4
        // static void MinMaxArray(int[] array, ref int min, ref int max)
        //{

        //    min = array.Min();
        //    max = array.Max();

        //}


        #endregion

        #region Function Q5
        //static long Factorial(int n)
        //{
        //    long result = 1;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //}
        #endregion

        #region Function Q6
        #endregion

        #region Function Q7
        // static void CalculateOperations(int num1, int num2, int num3, int num4, out int sumResult, out int subtractResult)
        //{
        //    sumResult = num1 + num2;

        //    subtractResult = num3 - num4;
        //}

        #endregion

        #region Function Q8
        //public static string ChangeChar(string input, int position, char newChar)
        //{
           
        //    input=input.Remove(position,1);
        //    input=input.Insert(position,newChar.ToString());

        //    return input;
        //}
        #endregion





        static void Main(string[] args)
        {
            #region 1.Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            //Passing By Value -> Copy of value
            //int a = 5;
            //Console.WriteLine("Before method call: " + a);
            //PassByValue(a);
            //Console.WriteLine("After method call: " + a);
            //Passing By Reference -> Using the actual value  
            //int a = 5;
            //Console.WriteLine("Before method call: " + a);
            //PassByReference(ref a);
            //Console.WriteLine("After method call: " + a);



            #endregion

            #region 2.Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Console.WriteLine("Enter Number");
            //int.TryParse(Console.ReadLine(), out int num);

            //int result=SumNum(num);
            //Console.WriteLine($"The sum of the digits of the number {num} is {result}");

            #endregion

            #region 3.Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //Console.WriteLine("Enter number to check is Prime or Not");
            //int.TryParse(Console.ReadLine(), out int number);

            //bool answer=IsPrime(number);
            //if (answer)
            //    Console.WriteLine($"{number} is prime");
            //else Console.WriteLine($"{number} is not prime");

            #endregion

            #region 4.Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //Console.Write("Enter the number of elements: ");
            //int.TryParse(Console.ReadLine(), out int n);
            //int[] arr = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Enter element {i + 1}: ");
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}
            //int min = 0, max = 0;

            //MinMaxArray(arr, ref min, ref max);

            //Console.WriteLine($"Minimum Value: {min}");
            //Console.WriteLine($"Maximum Value: {max}");

            #endregion

            #region 5.Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //Console.Write("Enter a number to calculate its factorial: ");
            //int.TryParse(Console.ReadLine(), out int number);

            //long factorial = Factorial(number);
            //Console.WriteLine($"The factorial of {number} is: {factorial}");


            #endregion

            #region 6.Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example
            //Passing by value -> the object itself is not duplicated. The reference is copied, so changes to the object inside the method will affect the original object.

            //Passing by ref ->changes made to the parameter will affect the original variable since the method has access to the actual memory location.


            #endregion

            #region 7.Explain passing  Reference type parameters write a suitable c# example
            //Console.WriteLine("Enter the first number ");
            //int.TryParse(Console.ReadLine(), out int num1);

            //Console.WriteLine("Enter the second number ");
            //int.TryParse(Console.ReadLine(), out int num2);

            //Console.WriteLine("Enter the third number ");
            //int.TryParse(Console.ReadLine(), out int num3);

            //Console.WriteLine("Enter the fourth number ");
            //int.TryParse(Console.ReadLine(), out int num4);


            //int sum, subtract;

            //CalculateOperations(num1, num2, num3, num4, out sum, out subtract);


            //Console.WriteLine($"Summation of num1 and num2: {sum}");
            //Console.WriteLine($"Subtraction of num3 and num4: {subtract}");

            #endregion

            #region 8.Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

            //string original = "Hello, World!";
            //int position = 7;
            //char newChar = 'X';

            //string modified = ChangeChar(original, position, newChar);

            //Console.WriteLine($"Original: {original}");
            //Console.WriteLine($"Modified: {modified}");

            #endregion

        }
    }
}
