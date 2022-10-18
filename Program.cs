using Microsoft.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        const string connectionString 
            = "Server=localhost,1433;Database=balta;User ID=sa;Password=xptoR@11drigo;Trusted_Connection=False; TrustServerCertificate=True;";

        using (var connection = new SqlConnection(connectionString))
        {
            Console.WriteLine("Conectado");
            connection.Open();

            using (var command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT [Id], [Title] FROM [Category]";

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"{reader.GetGuid(0)} - {reader.GetString(1)}");
                }
            }
        }
    }
}
