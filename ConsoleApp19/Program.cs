using System;
using System.Diagnostics;
using System.Xml.Linq;

Console.WriteLine("Set the price: ");
string price = Console.ReadLine();
string[] Input = price.Split(',');

int y;
int x;

y = Int32.Parse(Input[0]);
x = Int32.Parse(Input[2]);
int total = 0;

switch (Input[1])

{
    case "+":
        total = y + x;
        break;

    case "*":
        total = y * x;
        break;

    case "-":
        total = y - x;
        break;

    case "/":
        total = y / x;
        break;

    default:
        Console.WriteLine($"The price was set to: {price}");
        break;
}
Console.WriteLine($"The price was set to: {total}");
