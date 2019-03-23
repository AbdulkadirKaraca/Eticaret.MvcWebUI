using System;
using System.Collections.Generic;

namespace Eticaret.MvcWebUI.Models
{
    public partial class Kargo
    {
        public Kargo()
        {
            SiparisDetay = new HashSet<SiparisDetay>();
        }

        public int KargoId { get; set; }
        public string SirketAdi { get; set; }
        public string Telefon { get; set; }
        public string KargoDurumu { get; set; }

        public virtual ICollection<SiparisDetay> SiparisDetay { get; set; }
    }
}
