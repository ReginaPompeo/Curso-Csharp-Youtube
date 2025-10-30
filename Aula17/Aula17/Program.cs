namespace Aula17;

public class Program
{
    public static void Main()
    {
        string separator = "---------------------";

        //1. Declaração com inicialização de valores
        List<string> fruits = new List<string>()
        {
            "Manga",
            "Pera",
            "Uva"
        };

        //2. Acessar os valores
        Console.WriteLine(separator);
        Console.WriteLine(fruits[2]);

        Console.WriteLine(separator);

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        //3. Adicionar elementos
        Console.WriteLine(separator);
        fruits.Add("Limão");
        fruits.Add("Laranja");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        //4. Remover elementos
        Console.WriteLine(separator);
        fruits.Remove("Limão");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        //5. Contagem de elementos
        Console.WriteLine(separator);
        Console.WriteLine("Quantidade de frutas: " + fruits.Count);

        //6. Modificar um elemento 
        Console.WriteLine(separator);
        fruits[2] = "Maracujá";

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        //7. Limpar a lista
        Console.WriteLine(separator);
        fruits.Clear();
        
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
            Console.WriteLine("Zerado");
        }

        //8. Declarar sem incializar 
        Console.WriteLine(separator);
        List<int> numbers = new List<int>();

        numbers.Add(1);
        numbers.Add(10);
        numbers.Add(18);
        numbers.Add(36);
        
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}
