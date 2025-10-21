namespace Aula08;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===== Operadores Relacionais =====");
        Console.WriteLine("Digite o primeiro número (x): ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número (y): ");
        int y = Convert.ToInt32(Console.ReadLine());

        string result;

        //Operador de igualdade (==)
        if (x == y)
        {
            result = "X é igual a Y";
        }
        else
        {
            result = "X é diferente de Y";
        }
        Console.WriteLine("Com base no operador (==): " + result);

        //Operador de diferença (!=)
        if (x != y)
        {
            result = "X é diferente de Y";
        }
        else
        {
            result = "X é igual a Y";
        }
        Console.WriteLine("Com base no operador (!=): " + result);

        //Operador maior que (>)
        if (x > y)
        {
            result = "X é maior que Y";
        }
        else
        {
            result = "X é menor que Y";
        }
        Console.WriteLine("Com base no operador (>): " + result);

        //Operador menor que (<)
        if (x < y)
        {
            result = "X é menor que Y";
        }
        else
        {
            result = "X é maior que Y";
        }
        Console.WriteLine("Com base no operador (<): " + result);

        //Operador Maior ou Igual (>=)    
        if (x >= y)
        {
            result = "X é maior ou igual a Y";
        }
        else
        {
            result = "X é menor que Y e não é igual";
        }
        Console.WriteLine("Com base no operador (>=) " + result);

        //Operador Menor ou Igual (<=)
        if (x <= y)
        {
            result = "X é menor ou igual a Y";
        }
        else
        {
            result = "X não é menor e nem igual a Y";
        }
        Console.WriteLine("Com base no operador (>=) " + result);
    }
}