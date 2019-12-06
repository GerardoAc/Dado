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
                Console.WriteLine("suma {0}+{1}={2}",dado1.numeros[0],dado2.numeros[0],dado1.numeros[0]+dado2.numeros[0]);
                Console.WriteLine("suma {0}+{1}={2}", dado1.numeros[1], dado2.numeros[1], dado1.numeros[1] + dado2.numeros[1]);
                Console.WriteLine("suma {0}+{1}={2}", dado1.numeros[2], dado2.numeros[2], dado1.numeros[2] + dado2.numeros[2]);
                Console.WriteLine("suma {0}+{1}={2}", dado1.numeros[3], dado2.numeros[3], dado1.numeros[3] + dado2.numeros[3]);
                Console.WriteLine("suma {0}+{1}={2}", dado1.numeros[4], dado2.numeros[4], dado1.numeros[4] + dado2.numeros[4]);
                Console.WriteLine("suma {0}+{1}={2}", dado1.numeros[5], dado2.numeros[5], dado1.numeros[5] + dado2.numeros[5]);
              






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
            sumar(numerosCubo[0], numerosCubo[1], numerosCubo[2]);
            dibujar(numerosCubo[0], numerosCubo[1], numerosCubo[2]);
        }
        int[] numeros = new int[6];
        private void sumar(int n0, int n1,int n2) {
            numeros[0] = n0;
            numeros[1] =7- n0;
            numeros[2] = n1;
            numeros[3] = 7 - n1;
            numeros[4] = n2;
            numeros[5] = 7 - n2;
        }
       
    }
    }
