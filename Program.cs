using System;
using System.Globalization;

namespace CsE2
{
    public class Program
    {
        public static void Main()
        {
            //EXERCICIO 2
            Console.Write("Calculando a Area de um círculo\n\nInforme o Raio: ");
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = 3.14159 * Math.Pow(r, 2);
            Console.WriteLine("\nÁrea do Círculo: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("\nFim do Programa!\n");
        }
    }
}
