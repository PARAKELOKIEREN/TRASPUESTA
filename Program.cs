using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TRASPUESTA
{
    class Program
    {

        static void Main(string[] args)
        {
            string lineaActualDelArchivo;
            int[,] mat1 = new int[3, 5];
            int[,] mat2 = new int[5, 3];
            int a=0, b=0;
            
            using (StreamReader archivo = new StreamReader("test.txt"))
            //using (StreamReader archivo = new StreamReader("C:\\Users\\Public\\Documents\\YO\\test.txt"))
            {
                while ((lineaActualDelArchivo = archivo.ReadLine()) != null)
                {
                    string[] numeros = lineaActualDelArchivo.Split(',');

                    foreach (string num in numeros)
                    {
                        mat1[a, b] = Convert.ToInt32(num);//mat3    0,0 | 0,1 | 0,2 | 0,3 | 0,4 |
                                                          //        1,0 | 1,1 | 1,2 | 1,3 | 1,4 |
                                                          //        2,0 | 2,1 | 2,2 | 2,3 | 2,4 |
                        b++;//a=3   b=0
                        if (b == 5)
                        {
                            a++;
                            b = 0;
                        }
                        
                    }
                }

            }

            for(int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 4; j++)
                { 
                    mat2[j, i] = mat1[i, j];
                }
            }


            Console.WriteLine("\n");
            Console.Write("MATRIZ");
            Console.WriteLine("\n\n");

            
                for (int i = 0; i <= 2; i++)
                {
                    for (int j = 0; j <= 4; j++)
                    {
                        if (mat1[i, j] < 10)
                        {
                            Console.Write(Convert.ToString(' '));
                        }

                        Console.Write(mat1[i, j]);
                        if(mat1[i, j] < 10)
                        {
                            Console.Write(Convert.ToString(' '));
                        }
                        else
                        {
                            Console.Write(Convert.ToString(' '));
                        }
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\n\n\n\n");
                Console.Write("TRASPUESTA QUITANDO LA ULTIMA FILA");
                Console.WriteLine("\n\n");

                for (int i = 0; i <= 3; i++)
                {
                    for (int j = 0; j <= 2; j++)
                    {
                        Console.Write(mat2[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            Console.ReadKey();
        }
    }
}
