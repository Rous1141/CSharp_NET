using System;
namespace Zodiac
{
    //This is a normal casual code comment. Not bound by any rule or convention by Microsoft
    //Microsoft implore a comment convention for how-to-use library/function/method by the Swagger UI convention

    /// <summary>
    /// This is a comment with comment convention being executed. Descripting the class ZodiacCalculator, the method you use to calculate your Zodiac sign by using your birthday (date and month). By default, it is written in English, then it can convert to Vietnameese
    /// </summary>

    public class ZodiacCalculator
	{
        /// <summary>
        /// Method to enter your date of birth to calculate your Zodiac Sign and return them in many laguage formats.
        /// </summary>
        /// <param name="error">Return the error code if encounter any missinput</param>
        public static void GetZodiacSign(ref string error)
        {
            int date;
            int month;
            try
            {
                Console.Write("\nInput your date of birth: ");
                date = int.Parse(Console.ReadLine());
                Console.Write("\nInput your month of birth: ");
                month = int.Parse(Console.ReadLine());
                if(date>29 && month == 2)
                {
                    error = "Your Date Of Birth Doesn't Exist! Un-earthling Detected! Alerting The Authorites!";
                }
                else if (date > 31 || date <1 || month < 1 || month >12)
                {
                    error = "Your Date Of Birth Doesn't Exist! Un-earthling Detected! Alerting The Authorites!";
                }
                else if ((month == 4 || month == 6 || month == 9 || month == 11)&&date>30)
                {
                    error = "Your Date Of Birth Doesn't Exist! Un-earthling Detected! Alerting The Authorites!";
                }
                else
                {
                    string zodiacE = GetZodiacByEnglish(date, month);
                    string zodiacV = GetZodiacByVietnamese(zodiacE);
                    Console.WriteLine(@$"Based on what you inputted...
Your zodiac sign is: {zodiacE} in English or {zodiacV} in Vietnamese."+"\n\n");
                }
            }
            catch(Exception e)
            {
                error = "Invalid Input!\nFull error detail: "+e.ToString();
            }
        }

        /// <summary>
        /// This is the proper format using XML format. This is the method you use to calculate your Zodiac sign by using your birthday (date and month). By default, it is written in English.
        /// </summary>
        /// <param name="day">Day must be in between 1..31</param>
        /// <param name="month">Month must be in between 1..12</param>
        /// <returns></returns>

		public static string GetZodiacByEnglish(int day, int month)
		{
			string sign ="Hell Naw!!!";
            switch (month)
            {
                case 1:
                    sign = (day <= 19) ? "Capricorn" : "Aquarius"; break; //Jan
                case 2:
                    sign = (day <= 18) ? "Aquarius" : "Pisces"; break; //Feb
                case 3:
                    sign = (day <= 20) ? "Pisces" : "Aries"; break; //March
                case 4:
                    sign = (day <= 19) ? "Aries" : "Taurus"; break;//Arp
                case 5:
                    sign = (day <= 20) ? "Taurus" : "Gemini"; break; //May
                case 6:
                    sign = (day <= 21) ? "Gemini" : "Cancer"; break; //June
                case 7:
                    sign = (day <= 22) ? "Cancer" : "Leo"; break; //July
                case 8:
                    sign = (day <= 22) ? "Leo" : "Virgo"; break; //August
                case 9:
                    sign = (day <= 22) ? "Virgo" : "Libra"; break; //Sep
                case 10:
                    sign = (day <= 23) ? "Libra" : "Scorpio"; break; //Oct
                case 11:
                    sign = (day <= 22) ? "Scorpio" : "Sagittarius"; break; //Nov
                case 12:
                    sign = (day <= 21) ? "Sagittarius" : "Capricorn"; break; //Dec
                default:
                    break;
            }
            return sign;
		}

        /// <summary>
        /// Converting the Zodiac Calculator from English To Vietnamese
        /// </summary>
        /// <param name="englishZodiac">Send the English result to be translated into Vietnamese</param>
        /// <returns></returns>
        static public string GetZodiacByVietnamese(string englishZodiac)
        {
            string signV = "none";
            switch (englishZodiac)
            {
                case "Capricorn":
                    signV = "Ma Kết";break;
                case "Aquarius":
                    signV = "Bảo Bình"; break;
                case "Pisces":
                    signV = "Song Ngư"; break;
                case "Aries":
                    signV = "Bạch Dương"; break;
                case "Taurus":
                    signV = "Kim Ngưu"; break;
                case "Gemini":
                    signV = "Song Tử"; break;
                case "Cancer":
                    signV = "Cự Giải"; break;
                case "Leo":
                    signV = "Sư Tử"; break;
                case "Virgo":
                    signV = "Xử Nữ"; break;
                case "Libra":
                    signV = "Thiên Bình"; break;
                case "Scorpio":
                    signV = "Bọ Cạp"; break;
                case "Sagittarius":
                    signV = "Nhân Mã"; break;
                default:
                    signV = "Hakurei Reimu"; break;  //one of my dream girls
            }
            return signV;
        }
	}
}

