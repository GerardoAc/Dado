using System;

namespace Dado
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            Console.WriteLine("Precione Enter para visualizar ");
            while (Console.ReadKey().Key == ConsoleKey.Enter) {
               int[] numerosCubo= { 1,2,3};
                Console.WriteLine("nueva visulacion");
                Random random = new Random();
                int p= random.Next(1, 6);
                Console.WriteLine("{0}",p);
                Program dado = new Program();
                dado.dibujar(numerosCubo[0],numerosCubo[1],numerosCubo[2]);
            }
        }
        private void dibujar(int n1,int n2,int n3) {
            
            Console.WriteLine("            +++++++     ");
            Console.WriteLine("            +     +     ");
            Console.WriteLine("            + {0} +     ",n1);
            Console.WriteLine("            +     +     ");
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine("+     +     +     +     +");
            Console.WriteLine("+ {0}  +  {1} +  {2} +   {3} +",7-n2,7-n3,n2,n3);
            Console.WriteLine("+     +     +     +     +");
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine("            +     +      ");
            Console.WriteLine("            +   {0}  +     ",7-n1);
            Console.WriteLine("            +     +     ");
            Console.WriteLine("            +++++++      ");
        }
        }
    }

