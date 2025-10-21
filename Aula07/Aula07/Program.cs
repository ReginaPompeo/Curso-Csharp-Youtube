using System.Xml;

namespace Aula07;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("========== Operadores de atribuição ==========");

        //Inicializar a variável 
        int x = 10;
        Console.WriteLine("\nValor inicial da variável de X: " + x);
        //"\n" pula a linha

        //Operador de atribuição simples (=)
        x = 20;
        Console.WriteLine("\nAtribuição simples (=)");
        Console.WriteLine("Valor de X é: " + x);

        //Atribuição composta (incremento) (++)
        x++;  //Passa a valer 21 | x = x + 1

        Console.WriteLine("\nAtribuição composta Incremento (++)");
        Console.WriteLine("Novo valor de X é: " + x);

        //Atribuição composta  (+=)
        x+= 10;  //Passa a valer 31 | x = x + 10

        Console.WriteLine("\nAtribuição composta (+=)");
        Console.WriteLine("Novo valor de X é: " + x);

        //Atribuição composta  (-=)
        x -= 10;  //Passa a valer 21 | x = x - 10

        Console.WriteLine("\nAtribuição composta (-=)");
        Console.WriteLine("Novo valor de X é: " + x);

        //Atribuição composta  (*=)
        x *= 10;  //Passa a valer 210 | x = x * 10

        Console.WriteLine("\nAtribuição composta (*=)");
        Console.WriteLine("Novo valor de X é: " + x);

        //Atribuição composta  (/=)
        x /= 10;  //Passa a valer 21 | x = x / 10

        Console.WriteLine("\nAtribuição composta (/=)");
        Console.WriteLine("Novo valor de X é: " + x);
    }
}
