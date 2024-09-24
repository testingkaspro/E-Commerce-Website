using System;  // Importing the System namespace

/*public class Exercise2
{
    public static void Main()
    {
        int num1, rem1;

        Console.Write("\n\n");
        Console.Write("Input an integer : ");
        num1 = Convert.ToInt32(Console.ReadLine());

        rem1 = num1 % 2;

        if (rem1 == 0)
            Console.WriteLine("Even no. ", num1);
        else
            Console.WriteLine("Odd no. \n", num1);
    }
}

---------------------------------------------------------------------------------------------

public class abc
{
    public static void Main()
    {
        for (int i = 0; i < 99 - 1; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }

}

-----------------------------------------------------------------------------------------------

class A
{
    public static void Main()
    {
        Console.WriteLine("Enter the number :");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n > 0)
        {
            Console.WriteLine("Number is positive");
        }
        else if (n == 0)
        {
            Console.WriteLine("Number is neither positive nor negetive");
        }
        else
            Console.WriteLine("Number is negetive");
    }
}

-------------------------------------------------------------------------------------------

class B
{
    public static void Main()
    {

        Console.WriteLine("Enter two numbers :");

        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("First no. is greater");
        }
        else
        {
            Console.WriteLine("Second no. is greater");
        }
    }
}

--------------------------------------------------------------------------------------------

namespace swapNumbers
{
    class B
    {
        public static void Main()
        {
            int a, b, c;
            Console.WriteLine("Enter the number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number:");
            b = int.Parse(Console.ReadLine());
            c = a;
            a = c;
            b = c;
            Console.WriteLine(a);

        }
    }
}

---------------------------------------------------------------------------------------------


namespace check
{
    class Checking
    {
        public static void Main()
        {
            int a;
            Console.WriteLine("Enter the number : ");
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Number is divisible by 2");
            }

        }
    }
}

--------------------------------------------------------------------------------------------------


class Multiples
{
    public static void Main()
    {
        int a, b, i, sum = 0;
        for (i = 1; i < 100; i++)
        {
            a = i % 3;
            b = i % 5;
            if (a == 0 || b == 0)
            {
                Console.WriteLine("\t" + i);
                sum = sum + i;
            }
        }
        Console.WriteLine("Sum of all the multiples of 3 and 5 is : " + sum);
    }
}

-------------------------------------------------------------------------------------------------------------


class Multiple
{
    public static void Main()
    {
        int a, i;
        for (i = 17; i < 100; i++)
        {
            a = i % 17;
            if (a == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}

------------------------------------------------------------------------------------------------------------------


public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the Number : ");
        int number = int.Parse(Console.ReadLine());
        int sum = 0, reminder;

        while (number > 0)
        {
            reminder = number % 10;
            number = number / 10;
            sum = sum + reminder;


        }



        Console.WriteLine($"The Sum of Digits is : {sum}");
        Console.ReadKey();
    }
}

--------------------------------------------------------------------------------------------------------


class Recursion
{
    public static void Main(string[] args)
    {
        int number = 0934;
        int sum = sumOfDigits(number);
        Console.WriteLine($"Sum of digits of {number} is : {sum}");
    }

    static int sumOfDigits(int number)
    {
        if (number < 10)
        {
            return number;
        }
        else
        {
            return number % 10 + sumOfDigits(number / 10);
        }
    }
}

---------------------------------------------------------------------------------------------------------



class Person
{
    static void Main(string[] strings)
    {
        Console.WriteLine("Enter the height of person(in foot) : ");
        double height = double.Parse(Console.ReadLine());
        if (height <= 5.5)
        {
            Console.WriteLine("Person is Dwarf");
        }
        else if (height > 5.5 && height <= 5.8)
        {
            Console.WriteLine("Person is Average");
        }
        else
        {
            Console.WriteLine("Person is Taller");
        }
    }
}

---------------------------------------------------------------------------------------------------


class Multiplication
{
    static void Main(string[] args)
    {
        Console.Write("Multiplication Table of :");
        int num = int.Parse(Console.ReadLine());
         Console.WriteLine($" Multiplication table of {num}");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} * {i} = {num * i}");

        }
    }
}

---------------------------------------------------------------------------------------------------


class Programs
{
    static void Main(string[] args)
    {
        Console.Write("CHECK YOUR GRADE HERE : ");


        char grade = char.Parse(Console.ReadLine());
        Console.WriteLine($"Selected Grade : {grade}");

        switch (grade)
        {
            case 'A':
                Console.WriteLine("EXCELLENT");
                break;
            case 'B':
                Console.WriteLine("Very Good");
                break;
            case 'C':
                Console.WriteLine("Good");
                break;
            case 'D':
                Console.WriteLine("Poor");
                break;
            case 'E':
                Console.WriteLine("Very Poor");
                break;
            case 'F':
                Console.WriteLine("Fail");
                break;
            default:
                Console.WriteLine("Enter valid grade");
                break;
        }
    }
}

----------------------------------------------------------------------------------------------


Sum of two binary numbers

class BinaryNum
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first binary number : ");
        string binary1 = Console.ReadLine();
        Console.Write("Enter the second binary number : ");
        string binary2 = Console.ReadLine();

        int num1 = Convert.ToInt32(binary1, 2);
        int num2 = Convert.ToInt32(binary2, 2);

        int result = num1 + num2;
        int result2 = num1 * num2;

        string binaryResult = Convert.ToString(result, 2);
        Console.WriteLine($"Multiplication result in binary : {result2}");
        Console.WriteLine($"Sum resut in binary : {result}");

    }
}

-----------------------------------------------------------------------------------------------------------


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter the basenum : ");
        int basenum = int.Parse(Console.ReadLine());
        Console.Write("Enter the exponent1 : ");
        int exponent1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the exponent2 : ");
        int exponent2 = int.Parse(Console.ReadLine());

        int result = calculateResult(basenum, exponent1, exponent2);
        Console.WriteLine($"Result of multiplication is : {result}");
    }

    static int calculateResult(int basenum, int exponent1, int exponent2)
    {
        int result = (int)Math.Pow(basenum, exponent1) * (int)Math.Pow(basenum, exponent2);
        return result;
    }
}

---------------------------------------------------------------------------------------------------------------


class Program
{
    public static void Main(string[] args)
    {
        Console.Write("enter the basenum : ");
        int basenum = int.Parse(Console.ReadLine());
        Console.Write("Enter the exponent1 : ");
        int exponent1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the exponent2 : ");
        int exponent2 = int.Parse(Console.ReadLine());

        int result = calculateResult(basenum, exponent1, exponent2);
        Console.WriteLine($"Result of addition is : {result}");
    }

    static int calculateResult(int basenum, int exponent1, int exponent2)
    {
        int result = (int)Math.Pow(basenum, exponent1) / (int)Math.Pow(basenum, exponent2);
        return result;
    }
}

-----------------------------------------------------------------------------------------------------------------



class Program
{
        static void Main(string[] args)
    {
        int number = 12345; // Change this to any number you want to reverse
        int reversedNumber = ReverseNumber(number);




        Console.WriteLine($"Reversed number of {number} is : {reversedNumber}");

    }

        static int ReverseNumber(int num)
    {
        int reversed = 0;
        while (num > 0)
        {
            int remainder = num % 10;
            reversed = reversed * 10 + remainder;
            num = num / 10;
        }
        return reversed;
    }
}

------------------------------------------------------------------------------------------------------------------

bhai 

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the Number : ");
        int number = int.Parse(Console.ReadLine());

        int reversedNumber = ReverseNumber(number);
        Console.WriteLine($"Reversed number: {reversedNumber}");

        if (IsPalindrome(number))
        {
            Console.WriteLine($"{number} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{number} is not a palindrome.");
        }
    }

    static int ReverseNumber(int num)
    {
        int reversed = 0;
        while (num > 0)
        {
            int remainder = num % 10;
            reversed = reversed * 10 + remainder;
            num = num / 10;
        }
        return reversed;
    }

    static bool IsPalindrome(int num)
    {
        int originalNumber = num;
        int reversedNumber = ReverseNumber(num);
        return originalNumber == reversedNumber;
    }
}

---------------------------------------------------------------------------------------------------------------------


public class StarPattern
{
    public static void Main(string[] args)
    {

        for (int row = 1; row <= 5; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

---------------------------------------------------------------------------------------------


class Program
{
    static void Main(string[] strings)
    {
        int n = 7;
        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < n - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}


class Program
{
    static void Main(string[] strings)
    {
        int n = 7;
        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < n - i; j++)
            {
                Console.Write("*");
            }
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

--------------------------------------------------------------------------------------



class Program
{
    static void Main(string[] args)
    {
        int decimalNumber = 10;
        Console.WriteLine($"Binary equivalent of {decimalNumber}: {DecimalToBinary(decimalNumber)}");
    }

    static string DecimalToBinary(int decimalNumber)
    {
        if (decimalNumber == 0)
            return "0";
        else if (decimalNumber == 1)
            return "1";
        else
        {
            int remainder = decimalNumber % 2;
            int quotient = decimalNumber / 2;
            return DecimalToBinary(quotient) + remainder.ToString();
        }
    }
}

---------------------------------------------------------------------------------------


class Program
{
    static void Main(string[] args)
    {
        int number = 12321; 
        Console.WriteLine($"Is {number} a palindrome? {IsPalindrome(number)}");
    }

    static bool IsPalindrome(int number)
    {
        int originalNumber = number;
        int reversedNumber = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number /= 10;
        }

        return originalNumber == reversedNumber;
    }
}

----------------------------------------------------------------------------------------


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number");
        int a  = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number");
        int b = int.Parse(Console.ReadLine());

        int sum = a + b;
        Console.WriteLine("Sum is : " + sum);

        int multiply = a * b;
        Console.WriteLine("Multiplication is : " + multiply);

        int division = a / b;
        Console.WriteLine("Division is : "+ division);

        int substraction = a - b;
        Console.WriteLine("Difference is : "+ substraction);


    }
}

-------------------------------------------------------------------------------------

using System;

class Programs
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number : ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number : ");
        double y = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Choose the option :-");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division \t");

        Console.Write("Choose an option : ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine($"Addition: {x} + {y} = {x + y}");
                break;
            case 2:
                Console.WriteLine($"Subtraction: {x} - {y} = {x - y}");
                break;
            case 3:
                Console.WriteLine($"Multiplication: {x} * {y} = {x * y}");
                break;
            case 4:
                if (y == 0)
                {
                    Console.WriteLine("Error: Cannot divide by zero");
                }
                else
                {
                    Console.WriteLine($"Division: {x} / {y} = {x / y}");
                }
                break;
            default:
                Console.WriteLine("Enter valid option!!!!");
                break;
        }
    }
}

----------------------------------------------------------------------------------------------*/


using System;

class Programs
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number : ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number : ");
        double y = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Choose the option :-");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division \t");

        Console.Write("Choose an option : ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine($"Addition: {x} + {y} = {x + y}");
                break;
            case 2:
                Console.WriteLine($"Subtraction: {x} - {y} = {x - y}");
                break;
            case 3:
                Console.WriteLine($"Multiplication: {x} * {y} = {x * y}");
                break;
            case 4:
                if (y == 0)
                {
                    Console.WriteLine("Error: Cannot divide by zero");
                }
                else
                {
                    Console.WriteLine($"Division: {x} / {y} = {x / y}");
                }
                break;
            default:
                Console.WriteLine("Enter valid option!!!!");
                break;
        }
    }
}

