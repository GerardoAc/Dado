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
                Program dado1 = new Program();
                Program dado2 = new Program(); 
                //llenar dados
                dado1.llenarValoresDado();
                dado2.llenarValoresDado();

                    
             
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
             private void llenarValoresDado()
        {
            int[] numerosCubo = new int[3];
            int valorLado;

            for (int x = 0; x < numerosCubo.Length; x++)
            {
                numerosCubo[x] = 0;
            }
            while (numerosCubo[0] == 0 || numerosCubo[1] == 0 || numerosCubo[2] == 0)
            {
                Random random = new Random();
                if (numerosCubo[0] == 0)
                {
                    valorLado = random.Next(1, 6);
                    numerosCubo[0] = valorLado;
                }

                if (numerosCubo[1] == 0 && numerosCubo[0] != 0)
                {
                    valorLado = random.Next(1, 7);
                    if (valorLado != numerosCubo[0] && valorLado != 7 - numerosCubo[0])
                    {
                        numerosCubo[1] = valorLado;
                    }
                }
                if (numerosCubo[1] != 0 && numerosCubo[0] != 0 && numerosCubo[2] == 0)
                {
                    valorLado = random.Next(1, 7);
                    if (valorLado != numerosCubo[0] && valorLado != 7 - numerosCubo[0] && valorLado != numerosCubo[1] && valorLado != 7 - numerosCubo[1])
                    {
                        numerosCubo[2] = valorLado;
                    }
                }


            }

            dibujar(numerosCubo[0], numerosCubo[1], numerosCubo[2]);
        }

    }
    }

