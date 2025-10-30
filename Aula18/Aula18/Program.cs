namespace Aula18;
using System.IO;
using System.Net.Security;

public class Program
{
    public static void Main()
    {
        //1. Criar um arquivo
        //string content = "Hello World!";

        //File.WriteAllText("file.txt", content);

        //Console.WriteLine("Arquivo criado com sucesso!");

        //2. Criar o arquivo em um local específico
        //string path = @"C:\Users\ginac\source\repos\Aula18\fileName.txt";

        //string content = "Hello World!";

        //File.WriteAllText(path, content);

        //3. Criar um arquivo word
        //string path = @"C:\Users\ginac\source\repos\Aula18\";
        //string fileName = "arquivoWord.docx";
        //string filePath = path + fileName;

        //string content = "Helloooo world!";

        //File.WriteAllText(filePath, content);

        //Console.WriteLine("Arquivo criado com sucesso!");

        //4. Inserir um paágrafo  em um arquivo
        string path = @"C:\Users\ginac\source\repos\Aula18\";
        string fileName = "arquivoWord.docx";
        string filePath = path + fileName;

        //string additionalContent = " | TESTE DE AGORA";

        //File.AppendAllText(filePath, additionalContent);

        //Console.WriteLine("Arquivo atualizado com sucesso!");

        //5. Ler o arquivo
        string fileContent = File.ReadAllText(filePath);
        Console.WriteLine("Conteúdo do arquivo: " +  fileContent);

    }
}
