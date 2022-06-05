using System;
using System.Collections.Generic;
using System.Text;

namespace animalvsrobots
{
    abstract class Animal : IRacer
    {
        public int rng;
        private Runway yarismaPisti;

        public string Isim { get; set; }
        public int Konum { get; set; }
        public int YarismaciNo { get; set; }

        public abstract int HareketEt();
      

        public Animal()
        {
            
        }

    }
}
