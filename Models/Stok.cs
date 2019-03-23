using System;
using System.Collections.Generic;

namespace Eticaret.MvcWebUI.Models
{
    public partial class Stok
    {
        public int StokId { get; set; }
        public int GelenUrunAdeti { get; set; }
        public int SatilanUrunAdeti { get; set; }
        public DateTime? GelisTarihi { get; set; }
        public DateTime? SatisTarihi { get; set; }

        public virtual Urunler StokNavigation { get; set; }
    }
}
