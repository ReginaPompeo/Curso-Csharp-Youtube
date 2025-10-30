namespace Aula12;

public class Program
{
    public static void Main()
    {
        //Exemplo 1
        //int i = 0;

        //while (i <= 5)
        //{
        //    Console.WriteLine(i);
        //    i++;
        //}

        //Exemplo 2
        double budget = 100;

        while (budget > 0)
        {
            Console.WriteLine(budget);
            //Realizando a operação de diminuir
            budget--;
        }

        Console.WriteLine("Saldo insuficiente");
    }
}