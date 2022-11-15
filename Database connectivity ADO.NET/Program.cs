using System.Data;
using System.Data.SqlClient;

class Program
{
  static void Main(string[] args){
    string ConnectionString = @"Data Source=LAPTOP-HS0OJSCM\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
    SqlConnection con = new SqlConnection(ConnectionString);
    con.Open();
    SqlCommand command = new SqlCommand("SELECT * FROM demotable;",con);

    SqlDataReader dataReader = command.ExecuteReader();
    string output = "";
    while(dataReader.Read()){
      output = output+dataReader.GetValue(0)+"-"+dataReader.GetValue(1)+"\n";
      Console.WriteLine(output);
    }
    dataReader.Close();
    command.Dispose();
    con.Close();
  }
}