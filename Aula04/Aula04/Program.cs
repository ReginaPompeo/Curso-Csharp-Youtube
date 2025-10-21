namespace Aula04;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("---------CADASTRO DE USUÁRIOS----------");

        //Solicitar o nome do usuário
        Console.WriteLine("Digite seu nome:");
        string name = Console.ReadLine();
        
        //Solicitar a idade do usuário
        Console.WriteLine("Digite a sua idade:");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("-----------------------------------");

        //Saída de dados
        Console.WriteLine("O nome do usuário é: " + name);
        Console.WriteLine("A idade do usuário é: " + age);
    }
}