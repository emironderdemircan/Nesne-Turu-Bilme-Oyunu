using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b191210450_NDP_PROJE_
{
    class Bardak : IAtik //IAtik interface'si tanımlanıyor.
    {
        int IAtik.Hacim => 250; //Atığın hacmi giriliyor.

        Image IAtik.Image => Image.FromFile("images/bardak.jpg"); //Atığın resmi alınıyor.

        public string AtikTipi => "Bardak"; //Atığın ismi belirleniyor.
    }
}
