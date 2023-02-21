using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace februar_21
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write($"Dupla vagy egy vonalas keretet szeretnél: ");
            string adat = Console.ReadLine();

            Negyszog(10,8,20,10, adat);

            Console.ReadKey();
        }

        private static void Negyszog(int left,int top, int width, int heigth, string adat)
        {
            if (adat == "dupla")
            {

                //Bal felső

                Console.SetCursorPosition(left, top);
                Console.Write('╔');

                //Jobb felső
            
                Console.SetCursorPosition(left + width, top);
                Console.Write('╗');
            
                //Bal alsó
            
                Console.SetCursorPosition(left, top + heigth);
                Console.Write('╚');
            
                //Jobb alsó

                Console.SetCursorPosition(left + width, top + heigth);
                Console.Write('╝');

                //Vízszintes

                for (int i = left + 1; i < left+width; i++)
                {
                    Console.SetCursorPosition(i, top);
                    Console.Write('═');
                    Console.SetCursorPosition(i, top + heigth);
                    Console.Write('═');
                } 
            
           
            
                //Függőleges

                for (int i = top + 1; i < top + heigth; i++)
                {
                    Console.SetCursorPosition(left, i);
                    Console.Write('║');
                    Console.SetCursorPosition(left + width, i);
                    Console.Write('║');
                }

                for (int i = top + 1 ; i < top+heigth; i++)
                {
                    for (int j = left + 1 ; j < left + width; j++)
                    {
                        Console.SetCursorPosition(j,i);
                        Console.Write('▓');
                    }
               
                }

               

            }
            else
            {

                //Bal felső

                Console.SetCursorPosition(left, top);
                Console.Write('┌');

                //Jobb felső

                Console.SetCursorPosition(left + width, top);
                Console.Write('┐');

                //Bal alsó

                Console.SetCursorPosition(left, top + heigth);
                Console.Write('└');

                //Jobb alsó

                Console.SetCursorPosition(left + width, top + heigth);
                Console.Write('┘');

                //Vízszintes

                for (int i = left + 1; i < left + width; i++)
                {
                    Console.SetCursorPosition(i, top);
                    Console.Write('─');
                    Console.SetCursorPosition(i, top + heigth);
                    Console.Write('─');
                }



                //Függőleges

                for (int i = top + 1; i < top + heigth; i++)
                {
                    Console.SetCursorPosition(left, i);
                    Console.Write('│');
                    Console.SetCursorPosition(left + width, i);
                    Console.Write('│');
                }

                for (int i = top + 1; i < top + heigth; i++)
                {
                    for (int j = left + 1; j < left + width; j++)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.Write('▓');
                    }

                }

               

            }

        }
    }
}
                                