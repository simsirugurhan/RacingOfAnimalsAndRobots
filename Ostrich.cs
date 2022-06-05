using System;
using System.Collections.Generic;
using System.Text;

namespace animalvsrobots
{
    class Ostrich : Animal
    {
        private bool paralize
        {
            set;
            get;
        }

        public override int HareketEt()
        {
            Random r = new Random();
            rng = r.Next(0, 101);

            if(Konum < 0)
            {
                paralize = true;
            }

            if (rng < 50 && rng >= 0 && paralize == false) //koşma3ileri
            {
                return Konum += 3;
            }
            else if (rng < 70 && rng >= 50 && paralize == false) //hızlıkoşma6ileri
            {
                return Konum += 6;
            }
            else if (paralize == false)//kayma4geri
            {
                if (Konum > 4) //başlangıçtangeridüşemez
                {
                    return Konum -= 4; //kayma4geri
                }
                else if (Konum <= 4)
                {
                    return Konum = 0; //başlangıçtakal
                }
                else
                {
                    return Konum;
                }

            }
            else //paralize olmuş
            {
                return Konum;
            }
;
        }

        public Ostrich(String isim, int konum, int yarismaciNo, bool paralize)
        {
            Isim = isim;
            Konum = konum;
            YarismaciNo = yarismaciNo;
            paralize = this.paralize;
        }

    }
}
