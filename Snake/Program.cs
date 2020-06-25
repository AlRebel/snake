using System;
using System.Diagnostics.SymbolStore;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            const bool F = false;
            Console.CursorVisible = F;
            for (i = 1; i < 100; i++)
            {
                Point p1 = new Point();
                p1.x = i;
                p1.y = 7;
                p1.sym = '*';
                p1.Appear();
                p1.x = i - 1;
                p1.sym = ' ';
                p1.Appear();
                System.Threading.Thread.Sleep(100);
            };
            

            Console.ReadLine();
        }
    }
}
