using System;

namespace Conversion
{
    class Conversion
    {
        static void Main(string[] args)
        {
            // Cambio fijo
            const double USD = 4000.0;
            const double EUR = 4500.0;

            double montoCop = 0;

            // Pedir montos
            while (true)
            {
                Console.Write("Ingrese el monto en pesos colombianos: ");
                string? entrada = Console.ReadLine();

                // validación
                if (!string.IsNullOrEmpty(entrada) && double.TryParse(entrada, out montoCop) && montoCop > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ingrese un número válido mayor a 0");
                }
            }

            double montoUsd = montoCop / USD;
            double montoEur = montoCop / EUR;

            //Resultados
            Console.WriteLine($"El valor en USD es: {montoUsd:F2}");
            Console.WriteLine($"El valor en EUR es: {montoEur:F2}");
        }
    }
}
