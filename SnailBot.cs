using System;
using System.Collections.Generic;
using System.Text;

namespace animalvsrobots
{
    class SnailBot : Robot
    {
        public override int HareketEt()
        {
            return Konum += 1; //sürünme1ileri
        }

        public SnailBot(String isim, int konum, int yarismaciNo)
        {
            Isim = isim;
            Konum = konum;
            YarismaciNo = yarismaciNo;
        }
    }
}
