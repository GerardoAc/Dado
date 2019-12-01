using System;

namespace Dado
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            Console.WriteLine("Precione Enter para visualizar ");
            while (Console.ReadKey().Key == ConsoleKey.Enter) {
                Console.WriteLine("nueva visulacion");
                Program dado = new Program();
                dado.dibujar();
            }
        }
        private void dibujar() {
            
            Console.WriteLine("            +++++++     ");
            Console.WriteLine("            +     +     ");
            Console.WriteLine("            +     +     ");
            Console.WriteLine("            +     +     ");
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine("+     +     +     +     +");
            Console.WriteLine("+     +     +     +     +");
            Console.WriteLine("+     +     +     +     +");
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine("            +     +      ");
            Console.WriteLine("            +     +     ");
            Console.WriteLine("            +     +     ");
            Console.WriteLine("            +++++++      ");
        }
        }
    }

