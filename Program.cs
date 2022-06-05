using System;

namespace animalvsrobots
{
    class Program
    {
        static void Main(string[] args)
        {
            Racing yarisma = new Racing("yarismacilar.txt", 50 );
            yarisma.Baslat();
            yarisma.KonumlariYazdir();
        }
    }
}
