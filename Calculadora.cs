using System;

int num1, num2, op, res;
Console.WriteLine("Informe o primeiro número: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o segundo número: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Infome a operação a ser realizada: \n" +
                    "Adição = 1\n" +
                    "Subtração = 2\n" +
                    "Multiplicação = 3\n" +
                    "Divisão = 4");
op = Convert.ToInt32(Console.ReadLine());

if (op == 1)
{
    res = num1 + num2;
    Console.WriteLine(num1 + " + " + num2 + " = " + res);
} else if (op == 2)
{
    res = num1 - num2;
    Console.WriteLine(num1 + " - " + num2 + " = " + res);
} else if (op == 3)
{
    res = num1 * num2;
    Console.WriteLine(num1 + " * " + num2 + " = " + res);
} else if (op == 4)
{
    res = num1 / num2;
    Console.WriteLine(num1 + " / " + num2 + " = " + res);
} else
{
    Console.WriteLine("Inválido");
}
