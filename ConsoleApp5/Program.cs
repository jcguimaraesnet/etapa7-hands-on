using Dominio;
using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var empregado1 = new Analista("Julio Analista", 15000);
            Console.WriteLine($"Nome: {empregado1.Nome}");
            Console.WriteLine($"Salário normal: {empregado1.Salario:N2}");
            Console.WriteLine($"Salário bonificado: {empregado1.CalcularSalarioBonificado():N2}");

            var empregado2 = new Vendedor("Julio Vendedor", 15000);
            Console.WriteLine($"Nome: {empregado2.Nome}");
            Console.WriteLine($"Salário normal: {empregado2.Salario:N2}");
            Console.WriteLine($"Salário bonificado: {empregado2.CalcularSalarioBonificado():N2}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{empregado1}");
            Console.WriteLine($"{empregado2}");

        }
    }
}
