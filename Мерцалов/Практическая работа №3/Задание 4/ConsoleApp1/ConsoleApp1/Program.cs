using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class SQLCommand
{
    private string _connectionString;
    private string _commandText;

    public SQLCommand(string connectionString)
    {
        _connectionString = connectionString;
    }

    public string CommandText
    {
        get { return _commandText; }
        set { _commandText = value.ToUpper(); }
    }

    public List<string> Execute()
    {
        List<string> results = new List<string>();
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            using (var command = new SqlCommand(_commandText, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = reader.GetInt32(0);
                        var name = reader.GetString(1);
                        var age = reader.GetInt32(2);
                        string result = $"ID: {id}, Name: {name}, Age: {age}";
                        results.Add(result);
                        Console.WriteLine(result);
                    }
                }
            }
        }
        return results;
    }
}

public class MyIntList
{
    private List<int> _list;
    private int _capacity;

    public MyIntList(int capacity)
    {
        _list = new List<int>(capacity);
        _capacity = capacity;
    }

    public int Capacity
    {
        get { return _capacity; }
    }

    public int Count
    {
        get { return _list.Count; }
    }

    public void Add(int item)
    {
        if (_list.Count < _capacity)
        {
            _list.Add(item);
        }
        else
        {
            Console.WriteLine($"Список полон. Не удается добавить элемент {item}");
        }
    }

    public int this[int index]
    {
        get { return _list[index]; }
        set { _list[index] = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        string connectionString = "Data Source=(local);Initial Catalog=zd;Integrated Security=True";
        SQLCommand command = new SQLCommand(connectionString);
        command.CommandText = "SELECT * FROM personal";
        List<string> results = command.Execute();

        Console.WriteLine("Создание MyIntList...");
        MyIntList list = new MyIntList(3);
        Console.WriteLine($"List capacity: {list.Capacity}");

        Console.WriteLine("Добавление элементов в MyIntList...");
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);

        Console.WriteLine("nMyIntList:");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }

        Console.ReadLine();
    }
}
