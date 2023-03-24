using System;
using System.Data.SqlClient;


public class SQLCommand
{
    private string connectionString;
    private string commandText;

    public SQLCommand(string connectionString)
    {
        connectionString = connectionString;
    }

    public string CommandText
    {
        get { return commandText; }
        set { commandText = value.ToUpper(); }
    }

    public void Execute()
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (var command = new SqlCommand(commandText, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = reader.GetInt32(0);
                        var name = reader.GetString(1);
                        var age = reader.GetInt32(2);
                        Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");
                    }
                }
            }
        }
    }
}
/*Не смог исправть ошибки в интеренете почитал повториз через добавление ссылки не помогло 😢*/