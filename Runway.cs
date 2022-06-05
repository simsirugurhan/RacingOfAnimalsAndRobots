using System;
using System.Collections.Generic;
using System.Text;

namespace animalvsrobots
{
    class Runway
    {
        private int runway;

        public uint PistUzunlugu { get; set; }

        private string DurumuYazdir(string durum)
        {
            return durum; //değişecek
        }

        private void KonumdakiYarismacilar()
        {

        }

        private int KonumGuncelle(int konum)
        {
            return konum; //değişecek
        }

        private List<Object> YarismaciEkle(List<Object> yarismacilar)
        {
            return yarismacilar;
        }  
        
        public Runway(uint pistUzunlugu)
        {
            PistUzunlugu = pistUzunlugu;
        }

    }
}
