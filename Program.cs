//Napisz program pobierający od użytkownika dwie liczby całkowite. Program powinien
//wypisać parzyste liczby znajdujące się pomiędzy podanymi wartościami.

using System;

namespace Between
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give number a: ");
            int a=int.Parse(Console.ReadLine());
            Console.Write("Give number b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Even numbers between a and b : ");
            if (a < b)
            {
                Between(a, b);
            }
            else 
            {
                Between(b, a);
            }
            
        }
        static void Between(int a,int b)
        {
            for (int i=a+1; i < b; i++)
            {
                if (i%2== 0)
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
