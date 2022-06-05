using System;
using System.Collections.Generic;
using System.Text;

namespace animalvsrobots 
{
    abstract class Robot : IRacer
    {
        public int rng;
        private Runway yarismaPisti;
        private bool Bozuldu
        {
            set;
            get;
        }

        public string Isim { get; set; }
        public int Konum { get; set; }
        public int YarismaciNo { get; set; }

        public abstract int HareketEt();

        public Robot()
        {

        }

    }

    

}
