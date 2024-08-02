﻿string input = string.Empty;

while ((input = Console.ReadLine()) != "END")
{
    int valueInt;
    float valueFloat;
    char valueChar;
    bool valueBool;

    if (int.TryParse(input,out valueInt))
    {
        Console.WriteLine($"{input} is integer type");
    }
    else if (float.TryParse(input,out valueFloat))
    {
        Console.WriteLine($"{input} is floating point type");
    }
    else if (char.TryParse(input,out valueChar))
    {
        Console.WriteLine($"{input} is character type");
    }
    else if (bool.TryParse(input,out valueBool))
    {
        Console.WriteLine($"{input} is boolean type");
    }
    else
    {
        Console.WriteLine($"{input} is string type");
    }
}




