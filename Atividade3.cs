using System;

namespace Curso
{
    class Retangulo
    {
        public double Altura;
        public double Largura;

        public double CalculaArea()
        {
            return Altura * Largura;
        }

        public double CalculaPerimetro()
        {
            return (Altura * 2) + (Largura * 2);
        }
    }

    public static class Program
    {
        public static void Main(string[] args)
        {
            Retangulo m1 = new Retangulo();
            Retangulo m2 = new Retangulo();

            Console.WriteLine("Insira a altura do retângulo:");
            m1.Altura = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Insira a largura do retângulo:");
            m2.Largura = double.Parse(Console.ReadLine());

            double area = m1.CalculaArea();
            double perimetro = m1.CalculaPerimetro();
            double diagonal = Math.Sqrt(m1.Altura * m1.Altura + m2.Largura * m2.Largura);

            Console.WriteLine("A área do retângulo é " + area);
            Console.WriteLine("O perímetro do retângulo é " + perimetro);
            Console.WriteLine("A diagonal do retângulo é " + diagonal);
        } 
    }
}
