using System;

namespace EJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = -1;
            while (opcion != 0)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\n Bienvenido a la calculadora, seleccione una opcion:");
                    Console.WriteLine(" 0- Cerrar la aplicacion.");
                    Console.WriteLine(" 1- Dividir dos numeros.");
                    Console.Write(" Su opcion: ");
                    opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 0:
                            break;

                        case 1:
                            PantallaDivision();
                            break;

                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(" \n ------------------------");
                    Console.WriteLine($" {ex.Message} ");
                    Console.WriteLine(" ------------------------ \n");
                    Console.ReadKey();
                }
            }
        }

        static void PantallaDivision()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\n MENU DIVISION ");
                Console.Write("\n Ingrese el dividendo: ");
                double dividendo = double.Parse(Console.ReadLine());
                Console.Write("\n Ingrese el divisior: ");
                double divisor = double.Parse(Console.ReadLine());
                double resultado = Facade.DividirDosNumeros(dividendo, divisor);
                Console.Write($"\n El resultado es: {resultado}");
                Console.Write("\n\n ----- Pulse cualquier letra para volver ----- ");
                Console.ReadKey();
            }
            catch (DivisionPorCeroException ex)
            {
                Console.WriteLine(" \n ------------------------");
                Console.WriteLine($" {ex.Mensaje} ");
                Console.WriteLine(" ------------------------ \n");
                Console.ReadKey();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(" \n ------------------------");
                Console.WriteLine($" {ex.Message} ");
                Console.WriteLine(" ------------------------ \n");
                Console.ReadKey();
            }
        }
    }
}
