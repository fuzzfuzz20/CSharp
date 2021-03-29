using System;

namespace OverflowApp
{
class Program
{
static void Main(string[] args)
{
int i, max = int.MaxValue;
try
{
Console.WriteLine("Start of try statement");
i = max + 1;
Console.WriteLine("After default overflow");
unchecked
{
i = max + 1;
}
Console.WriteLine("After unchecked statement");
checked
{
i = max + 1;
}
Console.WriteLine("After checked statement");
}
catch (OverflowException e)
{
Console.WriteLine("caught an OverflowException");
}
}
}
}