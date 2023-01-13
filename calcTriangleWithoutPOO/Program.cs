using System.Globalization;

namespace calcTriangleWithoutOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double xA, xB, xC, yA, yB, yC;
            
            Console.WriteLine("entre com os dados do triangulo X:");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA+xB+xC)/2;
            double xArea = Math.Sqrt(p * (p - xA)*(p-xB) * (p - xC));

            Console.WriteLine($"A area de x é: {xArea:F4}");

            Console.WriteLine("entre com os dados do triangulo y:");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = (yA + yB + yC) / 2;
            double yArea = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine($"A area de y é: {yArea:F4}");
            if (xArea >= yArea) Console.WriteLine("o maior é x");
            else Console.WriteLine("o maior é Y");

        }
    }
}