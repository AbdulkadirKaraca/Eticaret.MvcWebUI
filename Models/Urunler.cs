using System;
using System.Collections.Generic;

namespace Eticaret.MvcWebUI.Models
{
    public partial class Urunler
    {
        public Urunler()
        {
            Resim = new HashSet<Resim>();
            Siparis = new HashSet<Siparis>();
            UrunOzellik = new HashSet<UrunOzellik>();
        }

        public int UrunId { get; set; }
        public int MarkaId { get; set; }
        public int KategoriId { get; set; }
        public string UrunAdi { get; set; }
        public string Acıklama { get; set; }
        public decimal AlisFiyat { get; set; }
        public decimal SatisFiyat { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime SonKullanmaTarihi { get; set; }

        public virtual Kategori Kategori { get; set; }
        public virtual Marka Marka { get; set; }
        public virtual Stok Stok { get; set; }
        public virtual ICollection<Resim> Resim { get; set; }
        public virtual ICollection<Siparis> Siparis { get; set; }
        public virtual ICollection<UrunOzellik> UrunOzellik { get; set; }
    }
}
