using System;
using System.Data.SQlite;

public class SqlClass
{
    string connectionString = "Data Source=mydatabase.db;Version=3;";


    public SqlClass()
	{
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            // Open the connection
            connection.Open();

            // Perform database operations here
            using (SQLiteCommand command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS MyTable (Id INTEGER PRIMARY KEY, Name TEXT);", connection))
            {
                command.ExecuteNonQuery();
            }

            // Close the connection
            connection.Close();
        }
    }
}
