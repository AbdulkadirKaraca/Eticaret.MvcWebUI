using System;
using System.Collections.Generic;

namespace Eticaret.MvcWebUI.Models
{
    public partial class Siparis
    {
        public int SatisId { get; set; }
        public int UrunId { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }

        public virtual SiparisDetay Satis { get; set; }
        public virtual Urunler Urun { get; set; }
    }
}
