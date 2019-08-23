using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var teste = new  Negocio.Servico.TesteService();
            var resultado = teste.Obter("Valor 1");

            Console.WriteLine(resultado.Valor);
        }
    }
}
