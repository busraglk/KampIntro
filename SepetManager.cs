﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler,Sepete Eklendi! :" + urun.Adi);
            //
            //
            //
        }

        // bu şekilde de kullanılabilir. Ancak tercih edilmemeli.
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler,Sepete Eklendi! :" + urunAdi);
        }
    }
 }
