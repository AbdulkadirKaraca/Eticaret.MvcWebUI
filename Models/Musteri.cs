using System;
using System.Collections.Generic;

namespace Eticaret.MvcWebUI.Models
{
    public partial class Musteri
    {
        public Musteri()
        {
            MusteriAdres = new HashSet<MusteriAdres>();
            SiparisDetay = new HashSet<SiparisDetay>();
        }

        public int MusteriId { get; set; }
        public bool Uyemi { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }

        public virtual Kullanici Kullanici { get; set; }
        public virtual ICollection<MusteriAdres> MusteriAdres { get; set; }
        public virtual ICollection<SiparisDetay> SiparisDetay { get; set; }
    }
}
