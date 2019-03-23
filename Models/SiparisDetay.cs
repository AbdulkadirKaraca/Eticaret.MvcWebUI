using System;
using System.Collections.Generic;

namespace Eticaret.MvcWebUI.Models
{
    public partial class SiparisDetay
    {
        public SiparisDetay()
        {
            Siparis = new HashSet<Siparis>();
        }

        public int SiparisId { get; set; }
        public int MusteriId { get; set; }
        public int DurumId { get; set; }
        public int KargoId { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public decimal ToplamTutar { get; set; }

        public virtual SiparisDurumu Durum { get; set; }
        public virtual Kargo Kargo { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual ICollection<Siparis> Siparis { get; set; }
    }
}
