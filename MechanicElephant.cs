using System;
using System.Collections.Generic;
using System.Text;

namespace animalvsrobots
{
    class MechanicElephant : Robot
    { 
        public override int HareketEt()
        { 
            Random r = new Random();
            rng = r.Next(0, 101);

            if(rng < 40 && rng >= 0) //yürüme2ileri
            {
                return Konum += 2;
            }else if (rng < 50 && rng >= 40) //koşma3ileri
            {
                return Konum += 3;
            }
            else //bekleme
            {
                return Konum = Konum;
            }

        }

        public MechanicElephant(string isim, int konum,int yarismaciNo)
        {
            Isim = isim;
            Konum = konum;
            YarismaciNo = yarismaciNo;
        }

       
    }
}
