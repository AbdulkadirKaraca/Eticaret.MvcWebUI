using System;
using System.Collections.Generic;

namespace Eticaret.MvcWebUI.Models
{
    public partial class SiparisDurumu
    {
        public SiparisDurumu()
        {
            SiparisDetay = new HashSet<SiparisDetay>();
        }

        public int DurumId { get; set; }
        public bool Kargodami { get; set; }
        public string Aciklama { get; set; }

        public virtual ICollection<SiparisDetay> SiparisDetay { get; set; }
    }
}
