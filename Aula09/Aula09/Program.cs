namespace Aula09;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===== Operadores lógicos =====");

        bool isLogged = true; // Verificar se o usuário está logado
        bool hasAdminAcces = false; // Verificar se o usuário tem acesso de admin

        Console.WriteLine("\nInformações do usuário:");
        Console.WriteLine("Usuário logado: " + isLogged);
        Console.WriteLine("Acesso ao painel de administrador: " + hasAdminAcces);

        Console.WriteLine("\nPermissões: ");

        //Operador (||) - Ou
        if (isLogged || hasAdminAcces) // está dizendo (isLogged == true || hasAdminAcces == true)
        {
            Console.WriteLine("Acesso ao sistema concedido.");
        }
        else
        {
            Console.WriteLine("Acesso ao sistema não concedido.");
        }

        //Operador (&&) - E
        if (isLogged && hasAdminAcces) // está dizendo (isLogged == true && hasAdminAcces == true)
        {
            Console.WriteLine("Acesso ao painel de admin conecedido.");
        }
        else
        {
            Console.WriteLine("Acesso ao painel de admin negado.");
        }

        //Operador (!) - "Não..."
        if (!isLogged) // Ao contrário de true == false
        {
            Console.WriteLine("Usuário não está logado.");
        }
        else
        {
            Console.WriteLine("Usuário está logado.");
        }
    }

}