namespace Aula16;

public class Program
{
    public static void Main()
    {
        string separator = "-----------------------------";

        //1. Declaração de Array inicializando com valores
        string[] fruits = { "Maçã", "Banana", "Caju", "Manga", "Abacaxi" };

        //2. Acessar os valores 
        Console.WriteLine(fruits[0]);

        Console.WriteLine(separator);

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        //Cada item é um índice
        //3. Contagem de índices
        Console.WriteLine(separator);
        Console.WriteLine("Quantidade de índices: " + fruits.Length);

        //4. Alterar os valores
        Console.WriteLine(separator);
        Console.WriteLine("Valor antes da alteração: " + fruits[1]);

        fruits[1] = "Morango";
        Console.WriteLine("Valor depois da alteração: " + fruits[1]);

        Console.WriteLine(separator);

        foreach (string fruit in fruits)
        {
            {
                Console.WriteLine(fruit);
            }
        }

        Console.WriteLine(separator);

        //5. Declaração sem inicializar
        int[] numbers = new int[5];

        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

