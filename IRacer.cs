using System;
using System.Collections.Generic;
using System.Text;

namespace animalvsrobots
{
    interface IRacer
    {
        string Isim
        {
            get;
            set;
        }

        int Konum
        {
            get;
            set;
        }

        int YarismaciNo
        {
            get;
            set;
        }

        int HareketEt();

    }
}
