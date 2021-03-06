﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b191210450_NDP_PROJE_
{
    class OrganikAtikKutusu : IAtikKutusu //IAtikKutusu interface'si tanımlanıyor.
    {
        public int BosaltmaPuani => 0; //Kutu boşaltılınca alınacak puan belirleniyor.

        public int Kapasite { get => 700; set => throw new NotImplementedException(); } //Kutunun kapasitesi belirleniyor.

        public int DoluHacim { get; set; } //Metotlar yazılıyor.

        public int DolulukOrani { get; set; } //Metotlar yazılıyor.


        //Kutu boşaltılınca olanlar hesaplanıyor ve değerler atanıyor.
        public bool Bosalt()
        {
            if (this.DolulukOrani >= 75)
            {
                this.DoluHacim = 0;
                this.DolulukOrani = 0;

                return true;
            }
            else
            {
                return false;
            }
        }

        //Atığın cinsi compare (string karşılaştırma) yöntemi ile karşılaştırılıyor.
        //Kutuların kapasitesi ile ilgili işlemler yapılıyor.
        public bool Ekle(IAtik atik)
        {

            if (string.Compare(atik.AtikTipi, "Domates") == 0 || string.Compare(atik.AtikTipi, "Salatalik") == 0)
            {
                if (this.Kapasite < this.DoluHacim + atik.Hacim)
                {
                    return false;
                }
                else if (this.DolulukOrani >= 75)
                {
                    return false;
                }
                else
                {
                    this.DoluHacim += atik.Hacim;
                    this.DolulukOrani = (this.DoluHacim * 100) / this.Kapasite;
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
