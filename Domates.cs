﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b191210450_NDP_PROJE_
{
    class Domates : IAtik //IAtik interface'si tanımlanıyor.
    {
        int IAtik.Hacim => 150; //Atığın hacmi giriliyor.

        Image IAtik.Image => Image.FromFile("images/domates.jpg"); //Atığın resmi alınıyor.

        public string AtikTipi => "Domates"; //Atığın ismi belirleniyor.
    }
}
