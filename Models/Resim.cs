using System;
using System.Collections.Generic;

namespace Eticaret.MvcWebUI.Models
{
    public partial class Resim
    {
        public int ResimId { get; set; }
        public int UrunId { get; set; }
        public string Resim1 { get; set; }

        public virtual Urunler Urun { get; set; }
    }
}
