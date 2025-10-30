namespace Aula11;
public class Program
{
    public static void Main()
    {
        //Exemplo 1
        //int number = 1;

        //switch (number)
        //{
        //    case 1:
        //        Console.WriteLine("O número é 1");
        //        break;

        //    case 2:
        //        Console.WriteLine("O número é igual a 2");
        //        break;
        //}

        //Exemplo 2
        //Console.WriteLine("===== Dia da semana =====");
        //Console.WriteLine("Digite um número de 1 a 7");

        //int dayOfWeek = Convert.ToInt32(Console.ReadLine());

        //switch (dayOfWeek)
        //{
        //    case 1:
        //        Console.WriteLine("Domingo");
        //        break;

        //    case 2:
        //        Console.WriteLine("Segunda-feira");
        //        break;

        //    case 3:
        //        Console.WriteLine("Terça-feira");
        //        break;

        //    case 4:
        //        Console.WriteLine("Quarta-feira");
        //        break;

        //    case 5:
        //        Console.WriteLine("Quinta-feira");
        //        break;

        //    case 6:
        //        Console.WriteLine("Sexta-feira");
        //        break;

        //    case 7:
        //        Console.WriteLine("Sábado");
        //        break;

        //    default:
        //        Console.WriteLine("Dia inválido");
        //        break;
        //}

        //Exemplo 3
        Console.WriteLine("===== Desempenho escolar =====");
        Console.WriteLine("Digite sua nota");

        int score = Convert.ToInt32(Console.ReadLine());

        switch (score)
        {
            case 10:
            case 9:
                Console.WriteLine("Ótimo!");
                    break;

            case 8:
            case 7:
                Console.WriteLine("Bom");
                break;

            case 6:
                Console.WriteLine("Ok");
                break;

            case 5:
                Console.WriteLine("Ruim");
                break;

            default:
                Console.WriteLine("Péssimo");
                break;

        }
    }
}
