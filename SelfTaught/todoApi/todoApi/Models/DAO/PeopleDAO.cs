using System;
using System.Collections;
using System.Data.Common;
using MySql.Data.MySqlClient;
using todoApi.DatabaseConnection;
using todoApi.Models.DTO;

namespace todoApi.Models.DAO
{
	public class PeopleDAO
	{
		public ArrayList GetAll()
		{
			ArrayList result = new();
			try
			{
                DBUtils dbutils = new();
				MySqlConnection con = dbutils.MakeConnection();

				con.Open();
				MySqlCommand cmd = con.CreateCommand();
				string sql = "SELECT * FROM `People` ";
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
                            string name = Convert.ToString(reader.GetValue(indexname));
                            int age = Convert.ToInt32(reader.GetValue(indexage));
                            string job = Convert.ToString(reader.GetValue(indexjob));
                            People people = new People(id, name, age, job);
                            result.Add(people);
                        }
                    }

                }
                con.Close();
                return result;

            }
            catch (Exception e)
			{
				Console.WriteLine(e);
			}
			return result;
		}
	}
}

