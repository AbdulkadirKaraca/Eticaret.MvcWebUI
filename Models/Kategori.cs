using System;
using System.Collections.Generic;

namespace Eticaret.MvcWebUI.Models
{
    public partial class Kategori
    {
        public Kategori()
        {
            OzellikTip = new HashSet<OzellikTip>();
            Urunler = new HashSet<Urunler>();
        }

        public int KategoriId { get; set; }
        public string KategoriTür { get; set; }

        public virtual ICollection<OzellikTip> OzellikTip { get; set; }
        public virtual ICollection<Urunler> Urunler { get; set; }
    }
}
