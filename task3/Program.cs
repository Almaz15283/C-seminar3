// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, User!");
Console.WriteLine("Найти расстояние между 2 - мя точками А(3,6) и В(2,1)");

double xa = 3;
double ya = 6;
double xb = 2;
double yb = 1;
double S = ((xa-xb)*(xa-xb)+(ya-yb)*(ya-yb));
S = Math.Sqrt(S);
Console.Write("Расстояние между точками = ");
Console.Write("{0:f3}", S);




