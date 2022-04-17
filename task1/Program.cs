// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, User!");

double x = 1;
double y = -0.5;

if (x > 0 && y > 0)
{
    Console.WriteLine("число находится в 1 четверти");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("число находится в 4 четверти");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("число находится во 2 четверти");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("число находится в 3 четверти");
}
