using System.Data.Common;
using MySql.Data.MySqlClient;
using System.Collections;

namespace ConnectingDatabase;

class Program
{
    static void Main(string[] args)
    {
        ArrayList peoplelist = new();
        //Console.WriteLine("Enter You Name:");
        //string name = Console.ReadLine();
        Console.WriteLine("Hello, World! I am trying to connect to MySQL Database and Query it With C# .NET");
        try
        {
            DBUtils dbutils = new DBUtils();
            //Attemp to make connection
            MySqlConnection con = dbutils.MakeConnection();
            //MANUALLY OPEN THE DAMN CONNECTION -> JAVA JUST DO IT FOR YOU
            con.Open();
            // MySqlCommand is like PrepareStatement in Java?
            MySqlCommand cmd = con.CreateCommand();
            String sql = " SELECT * FROM `People` ";
            //Prepare sql query command
            cmd.CommandText = sql;
            //What is 'using' syntax?
            //It will auto dispose the Object
            //Right after the code execution left the 'using' area
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //Get (index) of each row in Database?
                        //Why?
                        int indexid = reader.GetOrdinal("id");
                        int indexname = reader.GetOrdinal("name");
                        int indexage = reader.GetOrdinal("age");
                        int indexjob = reader.GetOrdinal("job");

                        //Get The Actual Data using location of the index
                        int id = Convert.ToInt32(reader.GetValue(indexid));
                        String name = Convert.ToString(reader.GetValue(indexname));
                        int age = Convert.ToInt32(reader.GetValue(indexage));
                        String job = Convert.ToString(reader.GetValue(indexjob));
                        People people = new People(id, name, age, job);
                        peoplelist.Add(people);
                    }
                }
                
            }
            //Close Connection
            con.Close();
            foreach (People pep in peoplelist)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Player:");
                Console.WriteLine(pep.Id);
                Console.WriteLine(pep.Name);
                Console.WriteLine(pep.Age);
                Console.WriteLine(pep.job);
                Console.WriteLine("-----------------------");
            }
            Console.WriteLine("\n\nIf You See This Line Then You Have Succeed In Connect To MySQL Database And Can Now Query It With .NET Framework! Congratulation\nNOW LEARN HOW TO MAKE API <3");
            
        }
        catch(Exception e)
        {
            // catch error to know that I've failed
            Console.WriteLine(e);
            Console.WriteLine("DB Connection Failed!");
        }
        finally
        {
            Console.WriteLine("Program Ended! Press Any Key To Exist!");
            Console.Read();
        }

    }
}

