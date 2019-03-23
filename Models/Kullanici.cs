using System;
using System.Collections.Generic;

namespace Eticaret.MvcWebUI.Models
{
    public partial class Kullanici
    {
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }

        public virtual Musteri KullaniciNavigation { get; set; }
    }
}
