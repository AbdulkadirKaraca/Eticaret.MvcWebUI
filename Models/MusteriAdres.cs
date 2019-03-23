using System;
using System.Collections.Generic;

namespace Eticaret.MvcWebUI.Models
{
    public partial class MusteriAdres
    {
        public int AdresId { get; set; }
        public int MusteriId { get; set; }
        public string Adres { get; set; }

        public virtual Musteri Musteri { get; set; }
    }
}
