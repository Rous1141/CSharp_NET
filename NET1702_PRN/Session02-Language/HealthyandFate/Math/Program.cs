using BMI; // using = import

namespace Math;

internal class Program
{
    public static void Main(string[] args)
    {
        //int sumA
        int sumB;
        int sum0;

        //sumA = IntSum1To100( ref sum0);
        sumB = IntSum1To100_02(out sum0);

        Console.WriteLine(sum0);
        Console.WriteLine(sum0);
    }

    public static int IntSum1To100(ref int sumEven)// 'ref' in C#? Another return method, Just like out but less contrain, optional return
    {
        int result = 0;
        int resultEven = 0;

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
                resultEven += i;
        }

        for (int i = 1; i <= 100; i++)
        {
            result += i;
        }
        sumEven = resultEven;

        return result;

    }

    public static int IntSum1To100_02(out int sumEven)// 'out' in C#? Another return method
    {
        int result = 0;
        int resultEven = 0;

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
                resultEven += i;
        }

        for (int i = 1; i <= 100; i++)
        {
            result += i;
        }
        sumEven = resultEven;

        return result;

    }

    static void CheckReadOnlyParams(in int n)// in? new C# syntax => Final Properties in Java
    {


        Console.WriteLine($"n before it change its value is: {n}");
        // n = 1111; -> ERROR! n is readonly
        Console.WriteLine($"n after it change its value is: {n}");
    }

    //public static void Main(string[] args)
    //{
    //    CheckReadOnlyParams(10);
    //    Print100Number();
    //    int sumEven;
    //    int sumAll = IntSum1To100(out sumEven); //Send this props into as Params the return the calculation for it
    //    // LIKE A POINTER IN C -> AHHHHHHHHHHHHHH

    //    int sumAll = IntSum1To100(out int sumOfEvent)

    //    Console.WriteLine("\n\nSumAll: {0} | SumEven: {1}", sumAll, sumEven);

    //    Console.Read();



    //}//Mantra: Static only goes with Static
    ////Static is critical to Design Pattern, ex: SingleTon

   
    //Print 100 interger number started from 1
    static void Print100Number()
    {
        Console.WriteLine(@"1
2
3
4
5
6
7
8
9
10
11
...
97
98
99
100
");
for (int i = 1; i <= 100; i++)
        {
            Console.Write($"{i} ");
        }

    }//Verbatim method - RAW String



    //static void Main(string[] args)
    //{
    //    // Call or Invoke Project BMI, NO Inherent, 
    //    Console.WriteLine("Hello, World!");
    //    double height = 1.7;
    //    double weight = 70;
    //   double bmi = BmiCalculator.GetBMI(weight, height);
    //    //USing Your Own Library
    //    //Call Method fro different class from different project -> Library/Dependency
    //    Console.WriteLine($"Your BMI is: {bmi}");
    //    Console.WriteLine($"Status: {BmiCalculator.EvaluateBmi(bmi)}");
    //    Console.WriteLine("Program ended. Press Any Key To Exist.");
    //    Console.Read();
    //}
}

