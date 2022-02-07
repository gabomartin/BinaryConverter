using BinaryConverterLogic;
using System;

namespace BinaryConverterConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            Menu();
            Separator();
            Console.WriteLine("Gracias por usar el conversor binario/decimal. Adios!");
            Separator();
            System.Threading.Thread.Sleep(5000);


        }

        static void Menu()
        {
            Console.Clear();
            Separator();
            Console.WriteLine("BIENVENIDO AL CONVERSOR BINARIO DE ENTERO");
            Separator();
            Console.WriteLine("SELECCIONE SU OPERACION A REALIZAR");
            Separator();
            Console.WriteLine("0) SALIR");
            Console.WriteLine("1) CONVERTIR DE ENTERO A BINARIO");
            Console.WriteLine("2) CONVERTIR DE BINARIO A ENTERO");
            Separator();
            int? menuOption = null;
            while (menuOption != 0)
            {
                try
                {
                    Console.WriteLine();
                    Console.Write("Su opción:");
                    menuOption = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Ingrese un numero valido.");

                }
                catch (Exception)
                {
                    Console.WriteLine();
                    Console.WriteLine("Se ha producido un error desconocido, por favor vuelva a intentarlo.");

                }
                switch (menuOption)
                {
                    case 0:
                        return;
      
                    case 1:
                        ConvertToBinary();
                        Menu();
                        break;
                    case 2:
                        ConvertToDecimal();
                        Menu();
                        break;
                    default:
                        Menu();
                        break;

                }
            }

            
            
        }
        static void ConvertToBinary()
        {
            Logic logic = new Logic();
            long nToConvert;
            try
            {
                Console.Clear();
                Separator();
                Console.WriteLine("CONVIRTIENDO A BINARIO...");
                Separator();
                Console.WriteLine();
                Console.Write("Introduzca el numero a convertir a binario:");
                nToConvert = Convert.ToInt64(Console.ReadLine());
                Separator();
                Console.WriteLine("El resultado es: " + logic.IntToBinary(nToConvert));
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para volver al menu.");
                Separator();
                Console.ReadKey();



            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Ingrese un numero valido.");
                ConvertToBinary();

            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Se ha producido un error desconocido, por favor vuelva a intentarlo.");
                ConvertToBinary();

            }

        }
        static void ConvertToDecimal()
        {
            Logic logic = new Logic();
            long nToConvert;
            try
            {
                Console.Clear();
                Separator();
                Console.WriteLine("CONVIRTIENDO A BINARIO...");
                Separator();
                Console.WriteLine();
                nToConvert = GetBinaryNumber();
                Separator();
                Console.WriteLine("El resultado es: " + logic.BinaryToInt(nToConvert));
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para volver al menu.");
                Separator();
                Console.ReadKey();



            }
            catch (System.FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Ingrese un numero binario valido.");
                ConvertToDecimal();

            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Se ha producido un error desconocido, por favor vuelva a intentarlo.");
                ConvertToDecimal();

            }

            long GetBinaryNumber()
            {
                Console.Write("Introduzca el numero a convertir a decimal:");
                string s = Console.ReadLine();

                foreach (char c in s)
                {
                    if (c != '0' && c != '1')
                    {
                        Console.WriteLine();
                        Console.WriteLine("El numero introducido no es binario, intentelo de nuevo.");
                        Console.WriteLine();
                        return GetBinaryNumber();
                    }
                      
                }

                return Convert.ToInt64(s);
            }

        }
        static void Separator()
        {
            Console.WriteLine();
            Console.WriteLine("########################################################");
            Console.WriteLine();
        }

    }
}
