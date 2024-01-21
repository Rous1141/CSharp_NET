using BMI;
using Zodiac;

namespace NewYearStory;
class Program
{
    static void Main(string[] args)
    {
        string choice = "0";
        string error="none";
        do
        {
            Menu.MainMenu();
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1": BmiCalculator.GetBMI(ref error);
                          if(error!="none") Console.WriteLine(error);
                          break;
                case "2": ZodiacCalculator.GetZodiacSign(ref error);
                          if(error != "none") Console.WriteLine(error);
                          break;
                case "3": Console.WriteLine("Program Terminated!"); break;
                default:
                    Console.WriteLine("Invalid Option!");
                    break;
            }
        } while (choice != "3");
    }
   

}
