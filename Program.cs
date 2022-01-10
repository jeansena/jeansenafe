using System;

c
namespace AreaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Calcula a area de um retângulo ");
            Console.WriteLine("Informe a altura: ");
            retangulo.Altura = Convert.toInt32(Console.ReadLine());

            Console.WriteLine("Informe a base/largura: ");
            retangulo.Base = Convert.toInt32(Console.ReadLine());

            retangulo.ExibeDados();
            Console.ReadKey();
        }
    }
}
