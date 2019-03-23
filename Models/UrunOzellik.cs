using System;
using System.Collections.Generic;

namespace Eticaret.MvcWebUI.Models
{
    public partial class UrunOzellik
    {
        public int UrunOzellikId { get; set; }
        public int OzellikTipId { get; set; }
        public int OzellikDegerId { get; set; }

        public virtual OzellikDeger OzellikDeger { get; set; }
        public virtual OzellikTip OzellikTip { get; set; }
        public virtual Urunler UrunOzellikNavigation { get; set; }
    }
}
