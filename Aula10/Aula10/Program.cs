namespace Aula10;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=====Calculadora Simples 2=====");

        bool varContinue = true;
        while (varContinue)
        {
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            //Selecionar o tipo de operação
            Console.WriteLine("\nEscolha uma operação: ");
            Console.WriteLine("1. Adição (+)");
            Console.WriteLine("2. Subtração (-)");
            Console.WriteLine("3. Multiplicação (*)");
            Console.WriteLine("4. Divisão (/)");
            Console.WriteLine("Digite o número da operação: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            if (operation == 1)
            {
                result = num1 + num2;
            }
            else if (operation == 2)
            {
                result = num1 - num2;
            }
            else if (operation == 3)
            {
                result = num1 * num2;
            }
            else if (operation == 4)
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Erro: Não é possível dividir um número por zero.");
                }
            }
            else
            {
                Console.WriteLine("Insira um número de 1 a 4.");
            }
            Console.WriteLine("\nResultado: " + result);

            Console.WriteLine("\nDeseja realizar outra operação (s/n)?");
            string response = Console.ReadLine();

            if (response != "s")
            {
                varContinue = false;
            }
        }

        Console.WriteLine("Obrigada por utilizar a calculadora!");
    }
}
