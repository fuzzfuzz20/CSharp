using System;
namespace StaticVsInstanceApp{
class StaticVsInstanceField
{
public int instanceVariable;
public static int staticVariable;
}
class Program
{
static void Main(string[] args)
{
StaticVsInstanceField obj = new StaticVsInstanceField();
obj.instanceVariable = 10;

StaticVsInstanceField.staticVariable = 20;

Console.WriteLine("instance variable={0}, static variable={1}", obj.instanceVariable,
StaticVsInstanceField.staticVariable);
}
}
}