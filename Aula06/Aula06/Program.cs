namespace Aula05;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("----------VERIFICAR DE NÚMEROS PARES OU ÍMPARES------------");
        Console.WriteLine("Digite um número:");
        int number = Convert.ToInt32(Console.ReadLine());
        int result = number % 2;

        if (result == 0)
        {
            Console.WriteLine("O número " + number + " é par.");
        }
        else
        {
            Console.WriteLine("O número " + number + " é ímpar.");
        }
    }
}


