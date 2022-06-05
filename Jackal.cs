using System;
using System.Collections.Generic;
using System.Text;

namespace animalvsrobots
{
    class Jackal : Animal
    {
        public override int HareketEt()
        {
            Random r = new Random();
            rng = r.Next(0, 101);

            if (rng < 30 && rng >= 0) //koşma3ileri
            {
                 return Konum += 3;
            }
            else if (rng < 80 && rng >= 30) //yürüme2ileri
            {
                return Konum += 2;
            }
            else 
            {
                if(Konum > 4) //başlangıçtangeridüşemez
                {
                     return  Konum -= 4; //kayma4geri
                }
                else if(Konum <= 4)
                {
                    return Konum = 0; //başlangıçtakal
                }
                else
                {
                    return Konum = Konum;
                }

            }

        }

        public Jackal(String isim, int konum, int yarismaciNo)
        {
            Isim = isim;
            Konum = konum;
            YarismaciNo = yarismaciNo;
        }

    }
}
