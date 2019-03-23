using System;
using System.Collections.Generic;

namespace Eticaret.MvcWebUI.Models
{
    public partial class OzellikDeger
    {
        public OzellikDeger()
        {
            UrunOzellik = new HashSet<UrunOzellik>();
        }

        public int OzellikDegerId { get; set; }
        public string OzellikDegerAdi { get; set; }
        public string OzellikDegerAcıklama { get; set; }
        public int OzellikTipId { get; set; }

        public virtual OzellikTip OzellikTip { get; set; }
        public virtual ICollection<UrunOzellik> UrunOzellik { get; set; }
    }
}
