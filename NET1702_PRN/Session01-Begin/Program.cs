namespace Healthy;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        

	double bmi = BMICalculator.GetBMI(1.7,80);
        
        Console.WriteLine("Your BMI is: " + bmi);
    	Console.WriteLine("Program Completed!");
	Console.WriteLine("Press Any Key To Exist!");
	string c = Console.ReadLine();
 	Console.WriteLine(c);
	}
}
