using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les2ON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // занятие 2
            /*
            угадайка
            
            Random rnd = new Random();
            int n = rnd.Next(0,11);

            while (true) {
                Console.Write("Enter number -> ");
                int i = Convert.ToInt32(Console.ReadLine());
                if (n == i)
                {
                    Console.WriteLine("You Win");
                }
                else if (n > i)
                {
                    Console.WriteLine("n>");
                }
                else if (n < i)
                {
                    Console.WriteLine("n<");
                }
                else
                    Console.WriteLine("Error enter!!!");
            }
            */

            /*
             Задание 1
        Написать программу, которая будет выполняться до тех пор, пока не будет введено слово exit.
        Помните, в цикле должно быть условие, которое отвечает за то, когда цикл должен завершиться.
        Это нужно, чтобы любой разработчик взглянув на ваш код, понял четкие границы вашего цикла.
        */
            
            Console.WriteLine("\n\n\n\t\tEx1\n\n");
            string strTemp = " ";            
            while (strTemp != "exit" && strTemp != "Exit" && strTemp != "EXIT") 
            {
                Console.Write("\tВведите exit для выхода из системы\n\tВведите слово -> ");
                strTemp = Console.ReadLine();
            }
         /*   
        Задание 2
        Нужно написать программу (используя циклы, обязательно пояснить выбор вашего цикла), 
        чтобы она выводила следующую последовательность 5 12 19 26 33 40 47 54 61 68 75 82 89 96
        Нужны переменные для обозначения чисел в условии цикла.
             */
            Console.WriteLine("\n\n\n\t\tEx2\n\n");
            for(int i = 5; i <= 96; i+=7) // можно сделать любым цыклом, но на мой взгляд for самый простой и частый в использовании 
            {
                if(i == 5) 
                Console.Write("\t" + i + " ");
                
                else
                Console.Write(i + " ");
            }
            Console.WriteLine("\n\n\n");
        }
    }
}
