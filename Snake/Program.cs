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
            Point p1 = new Point();
            p1.x = 10;
            p1.y = 7;
            p1.sym = 'O';
            p1.Appear();

            Console.ReadLine();
        }
    }
}
