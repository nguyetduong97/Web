namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DacsanngheandbContext : DbContext
    {
        public DacsanngheandbContext()
            : base("name=DacsanngheandbContext")
        {
        }

        public virtual DbSet<DANH_MUC_SP> DANH_MUC_SP { get; set; }
        public virtual DbSet<Lien_He> Lien_He { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Menu_Type> Menu_Type { get; set; }
        public virtual DbSet<SAN_PHAM> SAN_PHAM { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Tag_Tin> Tag_Tin { get; set; }
        public virtual DbSet<Tin_Tuc> Tin_Tuc { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DANH_MUC_SP>()
                .Property(e => e.MaDanhMuc)
                .IsUnicode(false);

            modelBuilder.Entity<Lien_He>()
                .Property(e => e.ContactID)
                .IsUnicode(false);

            modelBuilder.Entity<Lien_He>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Lien_He>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Lien_He>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Kieu)
                .IsUnicode(false);

            modelBuilder.Entity<Menu_Type>()
                .Property(e => e.MaMenu)
                .IsUnicode(false);

            modelBuilder.Entity<SAN_PHAM>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<SAN_PHAM>()
                .Property(e => e.Gia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SAN_PHAM>()
                .Property(e => e.DanhMuc)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.MaTag)
                .IsUnicode(false);

            modelBuilder.Entity<Tag_Tin>()
                .Property(e => e.MaTin)
                .IsUnicode(false);

            modelBuilder.Entity<Tag_Tin>()
                .Property(e => e.MaTag)
                .IsUnicode(false);

            modelBuilder.Entity<Tin_Tuc>()
                .Property(e => e.MaTin)
                .IsUnicode(false);

            modelBuilder.Entity<Tin_Tuc>()
                .Property(e => e.Tag)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Pass)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Phone)
                .IsUnicode(false);
        }
    }
}
