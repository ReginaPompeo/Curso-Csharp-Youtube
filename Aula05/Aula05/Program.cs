﻿namespace Aula05;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===========CALCULADORA=============");
        Console.WriteLine("Digite o valor do número 1:");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o valor do número 2:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        //int number1 = 10;
        //int number2 = 20;

        int sum = number1 + number2;
        int subtraction = number2 - number1;
        int multiplication = number1 * number2;
        int division = number2 / number1;
        //Module é o resto da divisão 
        int module = number2 % number1;

        Console.WriteLine("---------------------------------");
        Console.WriteLine("O valor da soma é: " + sum);
        Console.WriteLine("O valor da subtração é: " + subtraction);
        Console.WriteLine("O valor da multiplicação é: " + multiplication);
        Console.WriteLine("O valor da divisão é: " + division);
        Console.WriteLine("O resto da divisão é: " + module);
    }
}