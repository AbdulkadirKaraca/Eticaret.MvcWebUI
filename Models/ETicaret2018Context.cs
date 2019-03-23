using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Eticaret.MvcWebUI.Models
{
    public partial class ETicaret2018Context : DbContext
    {
        public ETicaret2018Context()
        {
        }

        public ETicaret2018Context(DbContextOptions<ETicaret2018Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AspnetApplications> AspnetApplications { get; set; }
        public virtual DbSet<AspnetRoles> AspnetRoles { get; set; }
        public virtual DbSet<AspnetUsers> AspnetUsers { get; set; }
        public virtual DbSet<AspnetUsersInRoles> AspnetUsersInRoles { get; set; }
        public virtual DbSet<Kargo> Kargo { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Marka> Marka { get; set; }
        public virtual DbSet<Musteri> Musteri { get; set; }
        public virtual DbSet<MusteriAdres> MusteriAdres { get; set; }
        public virtual DbSet<OzellikDeger> OzellikDeger { get; set; }
        public virtual DbSet<OzellikTip> OzellikTip { get; set; }
        public virtual DbSet<Resim> Resim { get; set; }
        public virtual DbSet<Siparis> Siparis { get; set; }
        public virtual DbSet<SiparisDetay> SiparisDetay { get; set; }
        public virtual DbSet<SiparisDurumu> SiparisDurumu { get; set; }
        public virtual DbSet<Stok> Stok { get; set; }
        public virtual DbSet<Urunler> Urunler { get; set; }
        public virtual DbSet<UrunOzellik> UrunOzellik { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=KADIR\\SQLEXPRESS;Initial Catalog=ETicaret-2018;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-preview3-35497");

            modelBuilder.Entity<AspnetApplications>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK__aspnet_A__C93A4C98DD0D1E4A")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_Applications");

                entity.HasIndex(e => e.ApplicationName)
                    .HasName("UQ__aspnet_A__30910331D33EAB94")
                    .IsUnique();

                entity.HasIndex(e => e.LoweredApplicationName)
                    .HasName("aspnet_Applications_Index")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspnetRoles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__aspnet_R__8AFACE1B255ABC94")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_Roles");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredRoleName })
                    .HasName("aspnet_Roles_index1")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetRoles)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Ro__Appli__6E8B6712");
            });

            modelBuilder.Entity<AspnetUsers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_U__1788CC4D76F97448")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_Users");

                entity.HasIndex(e => new { e.ApplicationId, e.LastActivityDate })
                    .HasName("aspnet_Users_Index2");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName })
                    .HasName("aspnet_Users_Index")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetUsers)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__Appli__3FD07829");
            });

            modelBuilder.Entity<AspnetUsersInRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK__aspnet_U__AF2760ADE4B64930");

                entity.ToTable("aspnet_UsersInRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("aspnet_UsersInRoles_index");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__RoleI__73501C2F");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__UserI__725BF7F6");
            });

            modelBuilder.Entity<Kargo>(entity =>
            {
                entity.Property(e => e.KargoId).HasColumnName("Kargo_id");

                entity.Property(e => e.KargoDurumu)
                    .IsRequired()
                    .HasColumnName("Kargo_Durumu")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SirketAdi)
                    .IsRequired()
                    .HasColumnName("Sirket_Adi")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Kategori>(entity =>
            {
                entity.Property(e => e.KategoriId).HasColumnName("Kategori_id");

                entity.Property(e => e.KategoriTür)
                    .IsRequired()
                    .HasColumnName("Kategori_Tür")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Kullanici>(entity =>
            {
                entity.Property(e => e.KullaniciId)
                    .HasColumnName("Kullanici_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.KullaniciAdi)
                    .IsRequired()
                    .HasColumnName("Kullanici_Adi")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Parola)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.KullaniciNavigation)
                    .WithOne(p => p.Kullanici)
                    .HasForeignKey<Kullanici>(d => d.KullaniciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kullanici_Musteri");
            });

            modelBuilder.Entity<Marka>(entity =>
            {
                entity.Property(e => e.MarkaId).HasColumnName("Marka_id");

                entity.Property(e => e.MarkaAdi)
                    .IsRequired()
                    .HasColumnName("Marka_Adi")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MarkaLogo)
                    .HasColumnName("Marka_logo")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Musteri>(entity =>
            {
                entity.Property(e => e.MusteriId).HasColumnName("Musteri_id");

                entity.Property(e => e.Adi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Soyadi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MusteriAdres>(entity =>
            {
                entity.HasKey(e => e.AdresId);

                entity.ToTable("Musteri_Adres");

                entity.Property(e => e.AdresId)
                    .HasColumnName("Adres_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adres)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MusteriId).HasColumnName("Musteri_id");

                entity.HasOne(d => d.Musteri)
                    .WithMany(p => p.MusteriAdres)
                    .HasForeignKey(d => d.MusteriId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Musteri_Adres_Musteri");
            });

            modelBuilder.Entity<OzellikDeger>(entity =>
            {
                entity.ToTable("Ozellik_Deger");

                entity.Property(e => e.OzellikDegerId).HasColumnName("Ozellik_Deger_id");

                entity.Property(e => e.OzellikDegerAcıklama)
                    .HasColumnName("Ozellik_Deger_Acıklama")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OzellikDegerAdi)
                    .IsRequired()
                    .HasColumnName("Ozellik_Deger_Adi")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OzellikTipId).HasColumnName("Ozellik_Tip_id");

                entity.HasOne(d => d.OzellikTip)
                    .WithMany(p => p.OzellikDeger)
                    .HasForeignKey(d => d.OzellikTipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ozellik_Deger_Ozellik_Tip");
            });

            modelBuilder.Entity<OzellikTip>(entity =>
            {
                entity.HasKey(e => e.OzellikId)
                    .HasName("PK_Teknik_Ozellik");

                entity.ToTable("Ozellik_Tip");

                entity.Property(e => e.OzellikId).HasColumnName("ozellik_id");

                entity.Property(e => e.KategoriId).HasColumnName("Kategori_id");

                entity.Property(e => e.OzellikAcıklama)
                    .HasColumnName("Ozellik_Acıklama")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OzellikAdi)
                    .IsRequired()
                    .HasColumnName("Ozellik_Adi")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Kategori)
                    .WithMany(p => p.OzellikTip)
                    .HasForeignKey(d => d.KategoriId)
                    .HasConstraintName("FK_Ozellik_Tip_Kategori1");
            });

            modelBuilder.Entity<Resim>(entity =>
            {
                entity.Property(e => e.ResimId).HasColumnName("Resim_id");

                entity.Property(e => e.Resim1)
                    .HasColumnName("Resim")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UrunId).HasColumnName("Urun_id");

                entity.HasOne(d => d.Urun)
                    .WithMany(p => p.Resim)
                    .HasForeignKey(d => d.UrunId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Resim_Urunler");
            });

            modelBuilder.Entity<Siparis>(entity =>
            {
                entity.HasKey(e => new { e.SatisId, e.UrunId });

                entity.Property(e => e.SatisId)
                    .HasColumnName("Satis_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UrunId).HasColumnName("Urun_id");

                entity.Property(e => e.Fiyat).HasColumnType("money");

                entity.HasOne(d => d.Satis)
                    .WithMany(p => p.Siparis)
                    .HasForeignKey(d => d.SatisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Siparis_Siparis_Detay");

                entity.HasOne(d => d.Urun)
                    .WithMany(p => p.Siparis)
                    .HasForeignKey(d => d.UrunId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Siparis_Urunler");
            });

            modelBuilder.Entity<SiparisDetay>(entity =>
            {
                entity.HasKey(e => e.SiparisId);

                entity.ToTable("Siparis_Detay");

                entity.Property(e => e.SiparisId).HasColumnName("Siparis_id");

                entity.Property(e => e.DurumId).HasColumnName("Durum_id");

                entity.Property(e => e.KargoId).HasColumnName("Kargo_id");

                entity.Property(e => e.MusteriId).HasColumnName("Musteri_id");

                entity.Property(e => e.SiparisTarihi)
                    .HasColumnName("Siparis_Tarihi")
                    .HasColumnType("date");

                entity.Property(e => e.TeslimTarihi)
                    .HasColumnName("Teslim_Tarihi")
                    .HasColumnType("date");

                entity.Property(e => e.ToplamTutar)
                    .HasColumnName("Toplam_Tutar")
                    .HasColumnType("money");

                entity.HasOne(d => d.Durum)
                    .WithMany(p => p.SiparisDetay)
                    .HasForeignKey(d => d.DurumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Siparis_Detay_Siparis_Durumu");

                entity.HasOne(d => d.Kargo)
                    .WithMany(p => p.SiparisDetay)
                    .HasForeignKey(d => d.KargoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Siparis_Detay_Kargo");

                entity.HasOne(d => d.Musteri)
                    .WithMany(p => p.SiparisDetay)
                    .HasForeignKey(d => d.MusteriId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Siparis_Detay_Musteri");
            });

            modelBuilder.Entity<SiparisDurumu>(entity =>
            {
                entity.HasKey(e => e.DurumId);

                entity.ToTable("Siparis_Durumu");

                entity.Property(e => e.DurumId).HasColumnName("Durum_id");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Stok>(entity =>
            {
                entity.Property(e => e.StokId)
                    .HasColumnName("Stok_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.GelenUrunAdeti).HasColumnName("Gelen_Urun_Adeti");

                entity.Property(e => e.GelisTarihi)
                    .HasColumnName("Gelis_Tarihi")
                    .HasColumnType("date");

                entity.Property(e => e.SatilanUrunAdeti).HasColumnName("Satilan_Urun_Adeti");

                entity.Property(e => e.SatisTarihi)
                    .HasColumnName("Satis_Tarihi")
                    .HasColumnType("date");

                entity.HasOne(d => d.StokNavigation)
                    .WithOne(p => p.Stok)
                    .HasForeignKey<Stok>(d => d.StokId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stok_Urunler");
            });

            modelBuilder.Entity<Urunler>(entity =>
            {
                entity.HasKey(e => e.UrunId)
                    .HasName("PK_Urunler_1");

                entity.Property(e => e.UrunId).HasColumnName("Urun_id");

                entity.Property(e => e.Acıklama)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AlisFiyat)
                    .HasColumnName("Alis_Fiyat")
                    .HasColumnType("money");

                entity.Property(e => e.EklenmeTarihi)
                    .HasColumnName("Eklenme_Tarihi")
                    .HasColumnType("date");

                entity.Property(e => e.KategoriId).HasColumnName("Kategori_id");

                entity.Property(e => e.MarkaId).HasColumnName("Marka_id");

                entity.Property(e => e.SatisFiyat)
                    .HasColumnName("Satis_Fiyat")
                    .HasColumnType("money");

                entity.Property(e => e.SonKullanmaTarihi)
                    .HasColumnName("SonKullanma_Tarihi")
                    .HasColumnType("date");

                entity.Property(e => e.UrunAdi)
                    .IsRequired()
                    .HasColumnName("Urun_Adi")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Kategori)
                    .WithMany(p => p.Urunler)
                    .HasForeignKey(d => d.KategoriId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Urunler_Kategori");

                entity.HasOne(d => d.Marka)
                    .WithMany(p => p.Urunler)
                    .HasForeignKey(d => d.MarkaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Urunler_Marka");
            });

            modelBuilder.Entity<UrunOzellik>(entity =>
            {
                entity.HasKey(e => new { e.UrunOzellikId, e.OzellikTipId, e.OzellikDegerId });

                entity.ToTable("Urun_Ozellik");

                entity.Property(e => e.UrunOzellikId)
                    .HasColumnName("Urun_Ozellik_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OzellikTipId).HasColumnName("Ozellik_Tip_id");

                entity.Property(e => e.OzellikDegerId).HasColumnName("Ozellik_Deger_id");

                entity.HasOne(d => d.OzellikDeger)
                    .WithMany(p => p.UrunOzellik)
                    .HasForeignKey(d => d.OzellikDegerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Urun_Ozellik_Diger_Ozellik1");

                entity.HasOne(d => d.OzellikTip)
                    .WithMany(p => p.UrunOzellik)
                    .HasForeignKey(d => d.OzellikTipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Urun_Ozellik_Teknik_Ozellik");

                entity.HasOne(d => d.UrunOzellikNavigation)
                    .WithMany(p => p.UrunOzellik)
                    .HasForeignKey(d => d.UrunOzellikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Urun_Ozellik_Urunler");
            });
        }
    }
}
