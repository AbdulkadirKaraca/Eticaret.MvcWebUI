using System;
using System.Collections.Generic;

namespace Eticaret.MvcWebUI.Models
{
    public partial class Marka
    {
        public Marka()
        {
            Urunler = new HashSet<Urunler>();
        }

        public int MarkaId { get; set; }
        public string MarkaAdi { get; set; }
        public string MarkaLogo { get; set; }

        public virtual ICollection<Urunler> Urunler { get; set; }
    }
}
