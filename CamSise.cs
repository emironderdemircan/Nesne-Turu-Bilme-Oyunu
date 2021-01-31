using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b191210450_NDP_PROJE_
{
    class CamSise : IAtik //IAtik interface'si tanımlanıyor.
    {
        int IAtik.Hacim => 600; //Atığın hacmi giriliyor.

        Image IAtik.Image => Image.FromFile("images/camsise.jpg"); //Atığın resmi alınıyor.

        public string AtikTipi => "CamSise"; //Atığın ismi belirleniyor.
    }
}
