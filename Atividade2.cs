using System;

namespace Curso
{
    class Funcionario
    {
        public string Nome;
        public double Salario;
    }

    public static class Program
    {
        public static void Main(string[] args)
        {
            Funcionario p1 = new Funcionario();
            Funcionario p2 = new Funcionario();
            double media;

            Console.WriteLine("Insira os dados do funcionário 1");
            Console.WriteLine("Nome:");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Salario:");
            p1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira os dados do funcionário 2");
            Console.WriteLine("Nome:");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Salario:");
            p2.Salario = double.Parse(Console.ReadLine());

            media = (p1.Salario + p2.Salario) / 2;
            Console.WriteLine("A média salarial é de " + media);
        }
    }
}
