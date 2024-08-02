
string type = Console.ReadLine();
string data = Console.ReadLine();
DataOperator(type, data);


static void DataOperator(string type, string data)
{
    if (type == "int")
    {
        Console.WriteLine(int.Parse(data) * 2);
    }
    else if (type == "real")
    {
        Console.WriteLine($"{(double.Parse(data) * 1.5):F2}");
    }
    else if (type == "string")
    {
        Console.WriteLine($"${data}$");
    }
}