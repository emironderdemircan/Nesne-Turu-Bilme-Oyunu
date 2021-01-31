using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b191210450_NDP_PROJE_
{
    interface IAtikKutusu : IDolabilen
    {
        
        int BosaltmaPuani { get; }
        bool Ekle(IAtik atik);
        bool Bosalt();
    }
}
