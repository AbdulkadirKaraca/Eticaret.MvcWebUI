using System;
using System.Collections.Generic;

namespace Eticaret.MvcWebUI.Models
{
    public partial class OzellikTip
    {
        public OzellikTip()
        {
            OzellikDeger = new HashSet<OzellikDeger>();
            UrunOzellik = new HashSet<UrunOzellik>();
        }

        public int OzellikId { get; set; }
        public string OzellikAdi { get; set; }
        public string OzellikAcıklama { get; set; }
        public int? KategoriId { get; set; }

        public virtual Kategori Kategori { get; set; }
        public virtual ICollection<OzellikDeger> OzellikDeger { get; set; }
        public virtual ICollection<UrunOzellik> UrunOzellik { get; set; }
    }
}
