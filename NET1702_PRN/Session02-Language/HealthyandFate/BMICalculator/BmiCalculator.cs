
namespace BMI
{
	public class BmiCalculator // internal is Private 
	{
        /// <summary>
        /// Method to calculate your BMI based on your Height and Weight.
        /// </summary>
        /// <param name="error">Return the error code if encounter any missinput</param>
        public static void GetBMI(ref string error)
        {
            double weight;
            double height;
            try
            {
                Console.Write("\nInput your weight in kilogram: ");
                weight = double.Parse(Console.ReadLine());
                Console.Write("\nInput your height in meter: ");
                height = double.Parse(Console.ReadLine());
                if (weight <= 0 || height <= 0)
                {
                    error = "Your Physiques Doesn't Exist! Un-earthling Detected! Alerting The Authorites!";
                }
                else
                {
                    string bmi = EvaluateBmi(CalculateBMI(weight, height));
                    
                    Console.WriteLine(@$"Based on what you inputted...
Your BMI is: {bmi}"+"\n");
                }
            }
            catch (Exception e)
            {
                error = "Invalid Input!\nFull error detail: " + e.ToString();
            }
        }

       internal static double CalculateBMI(double weight, double height) => (weight / (height * height)); //Body Expression to add productivity

        internal static string EvaluateBmi(double bmi)
        {
            string result = "N/A";
            if (bmi < 18.5)
                result = "Uderweight.";
            else if (bmi < 25)
                result = "Normal weight.";
            else if (bmi < 30)
                result = "Overweight.";
            else if (bmi < 25)
                result = "Normal weight.";
            else if (bmi < 35)
                result = "You have Class I obesity.";
            else if (bmi < 40)
                result = "You have Class II obesity.";
            else if (bmi > 40)
                result = "You have Class III obesity.";
            
            return result;
        }
    }
}

