﻿
int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int third = int.Parse(Console.ReadLine());
int fourth = int.Parse(Console.ReadLine());

int firstOperation = first + second;
int secondOperation = firstOperation / third;
int thirdOperation = secondOperation * fourth;

Console.WriteLine(thirdOperation);