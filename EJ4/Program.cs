using System;

namespace EJ4
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
                    Console.WriteLine("\n Bienvenid@ al sistema de Gestion de Solicitudes de Prestamos:");
                    Console.WriteLine(" 0- Cerrar la aplicacion.");
                    Console.WriteLine(" 1- Iniciar Solicitud de Prestamo.");
                    Console.Write(" Su opcion: ");
                    opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 0:
                            break;

                        case 1:
                            PantallaCrearCliente();
                            break;

                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(" \n ------------------------");
                    Console.WriteLine(" Error: El dato ingresado no es un numero.");
                    Console.WriteLine($" {ex.Message}  \n");
                    Console.WriteLine(" ------------------------ \n");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(" \n ------------------------");
                    Console.WriteLine(" Error: La opcion ingresada no es valida");
                    Console.WriteLine($" {ex.Message}  \n");
                    Console.WriteLine(" ------------------------ \n");
                }
            }
        }

        public static void PantallaCrearCliente()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\n ---- MENU CREAR CLIENTE ---- ");
                Console.WriteLine("\n Ingrese su Nombre y Apellido: ");
                Console.Write(" Nombre: ");
                String nombre = Console.ReadLine();
                Console.Write(" Apellido: ");
                String apellido = Console.ReadLine();
                Console.Write("\n Ingrese su Fecha de Nacimiento: ");
                DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("\n Seleccione que Tipo de Cliente desea ser: ");
                Console.WriteLine(" 1- No Cliente ");
                Console.WriteLine(" 2- Cliente Normal ");
                Console.WriteLine(" 3- Cliente Gold ");
                Console.WriteLine(" 4- Cliente Premium ");
                int opcion = int.Parse(Console.ReadLine());
                TipoCliente tipoCliente;
                switch (opcion)
                {
                    case 1:
                        tipoCliente = TipoCliente.NoCliente;
                        break;
                    case 2:
                        tipoCliente = TipoCliente.Cliente;
                        break;
                    case 3:
                        tipoCliente = TipoCliente.ClienteGold;
                        break;
                    case 4:
                        tipoCliente = TipoCliente.ClientePremium;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine("\n ¡Excelente! Ahora debera cargar los datos de su Empleo Actual.");
                Console.WriteLine(" Pulse cualquier tecla para continuar. ");
                Console.ReadKey();
                PantallaCrearEmpleo();

                Console.Clear();
                Console.WriteLine("\n Pulse cualquier tecla para finalizar el proceso de carga. ");
                Console.ReadKey();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(" \n ------------------------");
                Console.WriteLine(" Error: El dato ingresado no es un numero.");
                Console.WriteLine($" {ex.Message} ");
                Console.WriteLine(" ------------------------ \n");
                Console.ReadKey();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(" \n ------------------------");
                Console.WriteLine(" Error: La opcion ingresada no es valida");
                Console.WriteLine($" {ex.Message}  \n");
                Console.WriteLine(" ------------------------ \n");
            }
        }

        public static void PantallaCrearEmpleo()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\n ---- MENU CREAR CLIENTE ---- ");
                Console.Write("\n Ingrese su Sueldo Actual: ");
                double sueldo = double.Parse(Console.ReadLine());
                Console.WriteLine("\n Ingrese la Fecha de Ingreso a su Empleo: ");
                DateTime fechaIngreso = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("\n ¡Muy Bien! ");
                Console.ReadKey();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(" \n ------------------------");
                Console.WriteLine(" Error: El dato ingresado no es un numero.");
                Console.WriteLine($" {ex.Message} ");
                Console.WriteLine(" ------------------------ \n");
                Console.ReadKey();
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
}
