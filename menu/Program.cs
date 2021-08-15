using System;

namespace semana3_estructuras_de_control
{
    class Program
    {
        static void Main(string[] args)
        {

            principal();

        }

        static void principal()
        {
            int repetir_menu;
            System.Console.WriteLine("Estructuras de control en Visual C#");
            System.Console.WriteLine("1. Menú de opciones");
            System.Console.WriteLine("2. Salir");

            System.Console.WriteLine("Ingrese 1 para mostrar menú o 2 para salir. ");
            repetir_menu = Int32.Parse(Console.ReadLine());

            while (repetir_menu == 1)
            {
                opciones();
            }
        }


        static void opciones()
        {

            int opcion;

            System.Console.WriteLine("Ejemplos de estructuras de control");
            System.Console.WriteLine("Programa 1");
            System.Console.WriteLine("Programa 2");
            System.Console.WriteLine("Programa 3");
            System.Console.WriteLine("Programa 4");

            System.Console.WriteLine("Ingrese la opción: ");
            opcion = Int32.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    programa1();
                    break;
                case 2:
                    programa2();
                    break;
                case 3:
                    programa3();
                    break;
                case 4:
                    programa4();
                    break;
                default:
                    System.Console.WriteLine("Opción equivocada");
                    break;
            }
            //System.Console.ReadKey();
            principal();

        }

        static void programa1()
        {
            System.Console.WriteLine("Programa 1");

        }

        static void programa2()
        {
            System.Console.WriteLine("Programa 2");

        }

        static void programa3()
        {
            System.Console.WriteLine("Programa 3");

        }

        static void programa4()
        {
            System.Console.WriteLine("Programa 4");
        }

    }
}