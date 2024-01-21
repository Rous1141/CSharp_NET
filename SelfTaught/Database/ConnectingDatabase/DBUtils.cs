namespace ConnectingDatabase;
using MySql.Data.MySqlClient;

public class DBUtils
{
	public MySqlConnection MakeConnection()
	{
		String servername = "mysql-33a48e28-blazehendrix007-9343.a.aivencloud.com";
		int port = 28956;
		String database = "Test02";
		String username = "avnadmin";
		String password = "AVNS_bshtLjih_Fz-5HKLiOm";
		MySqlConnection con = null;
		//url to connect to MySQL Database (local or online hosting)
		String url = "Server=" + servername + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;

        con = new MySqlConnection(url);
		return con;
	}
}


