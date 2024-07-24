using System;

int x;
Console.WriteLine("Informe um número: ");
x = Convert.ToInt32(Console.ReadLine());
if (x % 2 == 0)
{
    Console.WriteLine(x + " é par");
} else
{
    Console.WriteLine(x + " é ímpar");
}
    
