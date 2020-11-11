using System;
using System.IO; // necessario para criação de arquivos biblioteca ja existente nao foi criação minha

namespace segundo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            TextWriter texto = new StreamWriter("Arquivo.txt");
            texto.WriteLine("Olá mundo novo e desconhecido");   
            texto.WriteLine("Meu nome é karine!");              
            texto.Close();                                      // nao intendi a necessidade  
            
            //---------------- terceiro bloco escrito -------------------------
            StreamWriter texto = File.AppendText("arquivo.txt");  
            texto.WriteLine("Olá mini mundo eu sou a ka!");      
            texto.Close();                                     // nao intendi a necessidade  

            //---------------- segundo cloco escrito -------------------------
            TextReader textoreader = new StreamReader("Arquivo.txt");
            Console.WriteLine(textoreader.ReadLine());   
            textoreader.Close();                               // nao intendi a necessidade  

            Console.ReadLine();                                // nao intendi a necessidade  */

            Console.WriteLine("Informe o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o seu numero: ");
            string telefone = Console.ReadLine();

            StreamWriter texto = File.AppendText("Arquivo.csv");
            texto.WriteLine(nome + ", " + telefone);
            texto.Close();
            Console.WriteLine("Registro conluido!");

            Console.ReadLine();
            
        }
    }
}
