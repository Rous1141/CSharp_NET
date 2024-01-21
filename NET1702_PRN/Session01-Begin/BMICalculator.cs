namespace Healthy;
class BMICalculator
{
   public static double GetBMI(double height, double weight) // in memories of Pascal -> C# use Pascal convention notation
	{
		double bmi = weight/(height * height);
		return bmi;
		
	}
}
