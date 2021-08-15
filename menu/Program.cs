using System;

namespace Estructuras_de_Control_en_Visual_CSharp
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
            System.Console.WriteLine("Estructuras de control en visual c#");
            System.Console.WriteLine("1. Menu de opciones");
            System.Console.WriteLine("2. Salir");

            System.Console.WriteLine("Ingrese 1 para mostrar menu o 2 para salir");
            repetir_menu = System.Int32.Parse(System.Console.ReadLine());

            while (repetir_menu == 1)
            {
                opciones();
            }

        }

        static void opciones()
        {
            int opcion;

            System.Console.WriteLine("Ejemplos de estructuras de control 1");
            System.Console.WriteLine("a. Programa 1");
            System.Console.WriteLine("b. Programa 2");
            System.Console.WriteLine("c. Programa 3");
            System.Console.WriteLine("d. Programa 4");

            System.Console.WriteLine("Ingrese la opcion: ");
            opcion = System.Int32.Parse(Console.ReadLine());

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
                    System.Console.WriteLine("Opcion equivocada");
                    break;

            }
            //System.Console.ReadKey();
            principal();
        }


        static void programa1()
        {
            System.Console.WriteLine("Programa 1");
            {
                Console.WriteLine("Esta parte se ejecuta primero");

                funcionsaludo();
                Console.WriteLine("Esta parte se ejecuta al final");
            }
            static void funcionsaludo()
            {
                Console.WriteLine("«Hola como estan!!!!!!!");
            }

        }


        static void programa2()
        {
            System.Console.WriteLine("Programa 2");
            int contador = 0;

        REPETIR:
            Console.WriteLine("Esta línea se repetirá 100 veces,  linea numero: {0}", contador);
            if
                (contador++ <= 100 - 1)
                goto REPETIR;

            Console.WriteLine("Después de 100 se imprimirá esta línea");
        }


        static void programa3()
        {
            System.Console.WriteLine("Programa 3");
            string secreta;
            string palabra;
            Console.WriteLine("ingrese la palabra secreta");
            secreta = Console.ReadLine();

            do
            {
                Console.WriteLine("vuelva a introducir la palabra secreta");
                palabra = Console.ReadLine();

                if (palabra != secreta) Console.WriteLine("palabra incorrecta");
            } while (palabra != secreta);

            Console.WriteLine("Palabra Correcta");
            Console.ReadKey();
        }


        static void programa4()
        {
            Console.WriteLine("ingrese un numero");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese un numero mayor que el anterior");
            int num2 = int.Parse(Console.ReadLine());
            while (num1 < num2)
            {
                Console.WriteLine("valores:" + num1); num1++;
            }
            Console.ReadKey();
        }
    }
}
