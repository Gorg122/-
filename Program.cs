using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {//ПЕТУХОВ 10 МИ-2, 12 ВАРИАНТ
        static string Vvedenie_stroki()
        {
            string a="наша мелодия:";
            string b;
            string str = Console.ReadLine();
            char[] M = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                M[i] = str[i];
                Console.WriteLine(M[i]);
               

                if (M[i] == 1)
                {
                    b= "до"+" ";
                    a += b;
                    Console.Write(a);
                }
                if (M[i] == 2)
                {
                    b= "ре"+" ";
                    a += b;
                    Console.Write(a);
                }
                if (M[i] == 3)
                {
                    b= "ми"+" ";
                    a += b;
                    Console.Write(a);
                }
                if (M[i] == 4)
                {
                    b= "фа"+" ";
                    a += b;
                    Console.Write(a);
                }
                if (M[i] == 5)
                {
                    b= "соль"+" ";
                    a += b;
                    Console.Write(a);
                }
                if (M[i] == 6)
                {
                    b= "ля"+" ";
                    a += b;
                    Console.Write(a);
                }
                if (M[i] == 7)
                {
                    b= "си"+" ";
                    a += b;
                    Console.Write(a);
                }
                
            }
            return a;

        }
       
        static void Main(string[] args)
        {
            Console.Write(Vvedenie_stroki());
            Console.ReadKey();

        }
    }
}
