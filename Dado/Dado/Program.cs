using System;

namespace Dado
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            Console.WriteLine("Precione Enter para visualizar ");
            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.WriteLine("nueva visulacion");
                Program dado = new Program();
                int[] numeros=new int[3];

                dado.dibujar(4,1,5);


                    
             
            }
        }
        private void dibujar(int n0, int n1, int n2)
        {

            Console.WriteLine("                ##########         ");
            Console.WriteLine("                #        #         ");
            Console.WriteLine("                #   {0}    #         ", n0);
            Console.WriteLine("                #        #         ");
            Console.WriteLine("###################################");
            Console.WriteLine("#      #        #        #        #");
            Console.WriteLine("# {0}    #    {1}   #    {2}   #    {3}   #", 7 - n1, 7 - n2, n1, n2);
            Console.WriteLine("#      #        #        #        #");
            Console.WriteLine("###################################");
            Console.WriteLine("                #        #         ");
            Console.WriteLine("                #   {0}    #         ", 7 - n0);
            Console.WriteLine("                #        #         ");
            Console.WriteLine("                ##########         ");
        }

    }
    }

