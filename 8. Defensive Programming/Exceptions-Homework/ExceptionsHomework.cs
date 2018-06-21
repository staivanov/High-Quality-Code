using System;
using System.Collections.Generic;
using System.Text;

class ExceptionsHomework
{
    //Add exception handling (where missing) and refactor all incorrect error handling in the code from the "Exceptions-Homework" project to follow the best practices for using exceptions.

    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        List<T> result = new List<T>();

        if (startIndex > count)
        {
            throw new ArithmeticException("Start index cant be above count.");
        }

        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }
        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        StringBuilder result = new StringBuilder();

        try
        {
            if (count > str.Length)
            {
               
            }

            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }

        catch (System.IndexOutOfRangeException ar)
        {
            Console.WriteLine("String length is smaller from count.", ar);
        }

        return result.ToString();
    }

    public static void CheckPrime(int number)
    {
        if ((number <= 0) || (number > int.MaxValue))
        {
            throw new ArgumentOutOfRangeException("Your  value is prime range.");
        }

        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                throw new ArithmeticException("The number is not prime!");
            }
        }
    }

    static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(String.Join(" ", subarr));

        var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(String.Join(" ", allarr));

        var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(String.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));
        Console.WriteLine(ExtractEnding("Hi", 100));

        try
        {
            CheckPrime(23);
            Console.WriteLine("23 is prime.");
        }
        catch (ArgumentOutOfRangeException OutOfRange)
        {
            Console.WriteLine("23 is not prime", OutOfRange);
        }

        try
        {
            CheckPrime(33);
            Console.WriteLine("33 is prime.");
        }
        catch (ArithmeticException ae)
        {
            Console.WriteLine("33 is not prime", ae);
        }

        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
