using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace animalvsrobots
{
    internal class Racing
    {
        private List<IRacer> yarismacilar = new List<IRacer>();
        private Runway yarismaPisti;

        public void Baslat()
        {
            Random r = new Random();
            int rng = r.Next(0, 101);

            int j = 0;
            while (yarismacilar[j].Konum <= yarismaPisti.PistUzunlugu)
            {
                bool astiMi = false;
                for (int i = 0; i < yarismacilar.Count; i++)
                {
                    yarismacilar[i].Konum = yarismacilar[i].HareketEt();

                    Type type = yarismacilar[i].GetType();

                    if (type.Equals(typeof(Jackal)) && yarismacilar[i].Konum > 0)
                    {
                        for(int k = 0; k < yarismacilar.Count; k++)
                        {
                            Type tur = yarismacilar[k].GetType();
                            if (tur.Equals(typeof(SnailBot)) && yarismacilar[k].Konum == yarismacilar[i].Konum)
                            {
                                if (rng < 25 || rng >= 0)
                                {
                                    yarismacilar[i].Konum -= 1;
                                }
                            }
                        }
                    }
                    else if (type.Equals(typeof(Ostrich)) && yarismacilar[i].Konum > 0)
                    {
                        for (int k = 0; k < yarismacilar.Count; k++)
                        {
                            Type tur = yarismacilar[k].GetType();
                            if (tur.Equals(typeof(SnailBot)) && yarismacilar[k].Konum == yarismacilar[i].Konum)
                            {
                                if (rng < 25 || rng >= 0)
                                {
                                    yarismacilar[i].Konum -= 1;
                                }
                            }
                            else if (tur.Equals(typeof(Jackal)) && yarismacilar[k].Konum == yarismacilar[i].Konum)
                            {
                                if (rng < 50 || rng >= 0)
                                {
                                    yarismacilar[i].Konum -= 110;
                                }
                            }else if(tur.Equals(typeof(MechanicElephant)) && yarismacilar[k].Konum == yarismacilar[i].Konum)
                            {
                                if (rng < 20 || rng >= 0)
                                {
                                    yarismacilar[i].Konum -= 110;
                                }
                            }
                        }
                    }
                    else if (type.Equals(typeof(SnailBot)) && yarismacilar[i].Konum > 0)
                    {
                        for (int k = 0; k < yarismacilar.Count; k++)
                        {
                            Type tur = yarismacilar[k].GetType();
                            if (tur.Equals(typeof(SnailBot)) && yarismacilar[k].Konum == yarismacilar[i].Konum && yarismacilar[k].YarismaciNo != yarismacilar[i].YarismaciNo)
                            {
                                if (rng < 25 || rng >= 0)
                                {
                                    yarismacilar[i].Konum -= 1;
                                }
                            }
                        }
                    }
                    else if (type.Equals(typeof(MechanicElephant)) && yarismacilar[i].Konum > 0)
                    {
                        for (int k = 0; k < yarismacilar.Count; k++)
                        {
                            Type tur = yarismacilar[k].GetType();
                            if (tur.Equals(typeof(SnailBot)) && yarismacilar[k].Konum == yarismacilar[i].Konum)
                            {
                                if (rng < 25 || rng >= 0)
                                {
                                    yarismacilar[i].Konum -= 1;
                                }
                            }
                        }
                    }

                        if (yarismacilar[i].Konum > yarismaPisti.PistUzunlugu)
                    {
                        yarismacilar[i].Konum = (int)yarismaPisti.PistUzunlugu;
                        astiMi = true;
                    }
                }

                if (yarismacilar.Count - 1 > j)
                {
                    j++;
                }
                else
                {
                    j = 0;
                }

                if (astiMi == true)
                {
                    break;
                }
                else
                {

                }

            }
        }

        public void KonumlariYazdir()
        {
            for (int i = 0; i < yarismacilar.Count; i++)
            {
                if(yarismacilar[i].Konum < 0)
                {
                    yarismacilar[i].Konum += 110; //devekusu paralize oldugu konum
                }

                Console.WriteLine(yarismacilar[i].Konum + " : " + yarismacilar[i].YarismaciNo + " | " + yarismacilar[i].Isim);

            }
       
        }

        public Racing(String yarismaciDosyaYolu, uint pistUzunlugu)
        {
            yarismaPisti = new Runway(pistUzunlugu);

            string dosyaYolu = @yarismaciDosyaYolu;
            
            FileStream fs = new FileStream(dosyaYolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            
            string yazi = sw.ReadLine();

            while (yazi != null)
            {
                //Console.WriteLine(yazi);

                string[] yarismaci = yazi.Split(' ');

                string tur = yarismaci[2];
                int yarismaciNo = int.Parse(yarismaci[0]);
                string isim = yarismaci[1];
                int konum = 0;
                if (tur.Equals("CAKAL"))
                {
                    yarismacilar.Add(new Jackal(isim, konum, yarismaciNo));
                    
                }
                else if (tur.Equals("MEKANIKFIL"))
                {
                    yarismacilar.Add(new MechanicElephant(isim, konum, yarismaciNo));
                    
                }
                else if (tur.Equals("SALYANBOT"))
                {
                    yarismacilar.Add(new SnailBot(isim, konum, yarismaciNo));
                    

                }
                else if (tur.Equals("DEVEKUSU"))
                { 
                    yarismacilar.Add(new Ostrich(isim, konum, yarismaciNo, false));
                }
                else
                {
                    Console.WriteLine("Tur tanimlanamadi, yarismaciya uygun tur halinde yaziniz!");
                }

                yazi = sw.ReadLine();
            }

            sw.Close();
            fs.Close();

        }

    }
}
