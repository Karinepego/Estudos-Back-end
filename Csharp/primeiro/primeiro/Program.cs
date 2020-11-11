using System
using System.Globalization

namespace primeiro
{
    class Program
    {
        static void Main(string[] args)//daqui começa a rodar o programa 
        {

            string produto1 = "Computador";
            string produto2 = "mesa de escritório";

            byte idade = 30;
            int codigo = 5299;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("produtos:");
            Console.WriteLine("{0}, cujo o preço é {1}",produto1, preco1);
            Console.WriteLine("{0}, cujo preço é {1}",produto2, preco2);
            Console.WriteLine("$ Registro: {idade} anos de idade, codigo {codigo} é genero: {genero} ");

            Console.WriteLine("$ Medida com 8 casas decimais: {medida}");
            Console.WriteLine("$ Arrendado (tres casas dcimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture " + medida.ToString(F2));
        }
    }
}
