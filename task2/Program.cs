// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, User!0");
Console.WriteLine(" Введите номер четверти");
string quarter = Console.ReadLine();
int a = Convert.ToInt32(quarter);

if (a == 1)
{
    Console.WriteLine(" Х любое положительное и У любое положительное");

}
if (a == 2)
{
    Console.WriteLine(" Х любое отрицательное и У любое положительное");

}
if (a == 3)
{
    Console.WriteLine(" Х любое отрицательное и У любое отрицательное");

}
if (a == 4)
{
    Console.WriteLine(" Х любое положительное и У любое отрицательное");

}