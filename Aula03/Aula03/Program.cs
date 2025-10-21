namespace Aula03;

public class Program
{
    public static void Main()
    {
        /*
        int number = 30;
        number = 20;
        number = 10;
        // No final vai valer 10 porque o ultimo que prevalece
        Console.WriteLine("O valor da variável era:  " + number);
        // O valor permanece sendo 10 porque o código roda em ordem;
        number = 5;
        Console.WriteLine("O valor da variável é: " + number);
        Os tipos de variáveis são var, dynamic e obj
        */
        // const int number = 1000;

        var teste = "Regina P";
        //teste = 500;
        // a var determina o tipo (se é string, int, double...) através da primeira determinação
        Console.WriteLine("O valor da variável é: " + teste);

        dynamic variable = 20;
        variable = "Antônio";
        // A dynamic aceita pois é uma variável dinâmica
        Console.WriteLine("A dynamic é: " + variable);   
    }
}