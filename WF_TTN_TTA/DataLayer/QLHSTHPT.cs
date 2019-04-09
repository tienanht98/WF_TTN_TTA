namespace WF_TTN_TTA.DataLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLHSTHPT : DbContext
    {
        public QLHSTHPT()
            : base("name=QLHSTHPTContex")
        {
        }

        public virtual DbSet<DANTOC> DANTOCs { get; set; }
        public virtual DbSet<DIEM> DIEMs { get; set; }
        public virtual DbSet<GIAOVIEN> GIAOVIENs { get; set; }
        public virtual DbSet<HANHKIEM> HANHKIEMs { get; set; }
        public virtual DbSet<HOCKY> HOCKies { get; set; }
        public virtual DbSet<HOCLUC> HOCLUCs { get; set; }
        public virtual DbSet<HOCSINH> HOCSINHs { get; set; }
        public virtual DbSet<KETQUA> KETQUAs { get; set; }
        public virtual DbSet<KQ_CA_NAM_MON_HOC> KQ_CA_NAM_MON_HOC { get; set; }
        public virtual DbSet<KQ_CA_NAM_TONG_HOP> KQ_CA_NAM_TONG_HOP { get; set; }
        public virtual DbSet<KQ_HOC_KY_MON_HOC> KQ_HOC_KY_MON_HOC { get; set; }
        public virtual DbSet<KQ_HOC_KY_TONG_HOP> KQ_HOC_KY_TONG_HOP { get; set; }
        public virtual DbSet<KHOILOP> KHOILOPs { get; set; }
        public virtual DbSet<LOAIDIEM> LOAIDIEMs { get; set; }
        public virtual DbSet<LOAINGUOIDUNG> LOAINGUOIDUNGs { get; set; }
        public virtual DbSet<LOP> LOPs { get; set; }
        public virtual DbSet<MONHOC> MONHOCs { get; set; }
        public virtual DbSet<NAMHOC> NAMHOCs { get; set; }
        public virtual DbSet<NGHENGHIEP> NGHENGHIEPs { get; set; }
        public virtual DbSet<NGUOIDUNG> NGUOIDUNGs { get; set; }
        public virtual DbSet<PHANCONG> PHANCONGs { get; set; }
        public virtual DbSet<PHANLOP> PHANLOPs { get; set; }
        public virtual DbSet<TONGIAO> TONGIAOs { get; set; }
        public virtual DbSet<QUYDINH> QUYDINHs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DANTOC>()
                .Property(e => e.MaDanToc)
                .IsUnicode(false);

            modelBuilder.Entity<DANTOC>()
                .HasMany(e => e.HOCSINHs)
                .WithRequired(e => e.DANTOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIEM>()
                .Property(e => e.MaHocSinh)
                .IsUnicode(false);

            modelBuilder.Entity<DIEM>()
                .Property(e => e.MaMonHoc)
                .IsUnicode(false);

            modelBuilder.Entity<DIEM>()
                .Property(e => e.MaHocKy)
                .IsUnicode(false);

            modelBuilder.Entity<DIEM>()
                .Property(e => e.MaNamHoc)
                .IsUnicode(false);

            modelBuilder.Entity<DIEM>()
                .Property(e => e.MaLop)
                .IsUnicode(false);

            modelBuilder.Entity<DIEM>()
                .Property(e => e.MaLoai)
                .IsUnicode(false);

            modelBuilder.Entity<GIAOVIEN>()
                .Property(e => e.MaGiaoVien)
                .IsUnicode(false);

            modelBuilder.Entity<GIAOVIEN>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<GIAOVIEN>()
                .Property(e => e.MaMonHoc)
                .IsUnicode(false);

            modelBuilder.Entity<GIAOVIEN>()
                .HasMany(e => e.LOPs)
                .WithRequired(e => e.GIAOVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GIAOVIEN>()
                .HasMany(e => e.PHANCONGs)
                .WithRequired(e => e.GIAOVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HANHKIEM>()
                .Property(e => e.MaHanhKiem)
                .IsUnicode(false);

            modelBuilder.Entity<HANHKIEM>()
                .HasMany(e => e.KQ_CA_NAM_TONG_HOP)
                .WithRequired(e => e.HANHKIEM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HANHKIEM>()
                .HasMany(e => e.KQ_HOC_KY_TONG_HOP)
                .WithRequired(e => e.HANHKIEM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOCKY>()
                .Property(e => e.MaHocKy)
                .IsUnicode(false);

            modelBuilder.Entity<HOCKY>()
                .HasMany(e => e.DIEMs)
                .WithRequired(e => e.HOCKY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOCKY>()
                .HasMany(e => e.KQ_HOC_KY_TONG_HOP)
                .WithRequired(e => e.HOCKY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOCKY>()
                .HasMany(e => e.KQ_HOC_KY_MON_HOC)
                .WithRequired(e => e.HOCKY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOCLUC>()
                .Property(e => e.MaHocLuc)
                .IsUnicode(false);

            modelBuilder.Entity<HOCLUC>()
                .HasMany(e => e.KQ_CA_NAM_TONG_HOP)
                .WithRequired(e => e.HOCLUC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOCLUC>()
                .HasMany(e => e.KQ_HOC_KY_TONG_HOP)
                .WithRequired(e => e.HOCLUC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOCSINH>()
                .Property(e => e.MaHocSinh)
                .IsUnicode(false);

            modelBuilder.Entity<HOCSINH>()
                .Property(e => e.MaDanToc)
                .IsUnicode(false);

            modelBuilder.Entity<HOCSINH>()
                .Property(e => e.MaTonGiao)
                .IsUnicode(false);

            modelBuilder.Entity<HOCSINH>()
                .Property(e => e.MaNNghiepCha)
                .IsUnicode(false);

            modelBuilder.Entity<HOCSINH>()
                .Property(e => e.MaNNghiepMe)
                .IsUnicode(false);

            modelBuilder.Entity<HOCSINH>()
                .HasMany(e => e.DIEMs)
                .WithRequired(e => e.HOCSINH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOCSINH>()
                .HasMany(e => e.KQ_CA_NAM_TONG_HOP)
                .WithRequired(e => e.HOCSINH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOCSINH>()
                .HasMany(e => e.KQ_CA_NAM_MON_HOC)
                .WithRequired(e => e.HOCSINH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOCSINH>()
                .HasMany(e => e.KQ_HOC_KY_TONG_HOP)
                .WithRequired(e => e.HOCSINH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOCSINH>()
                .HasMany(e => e.KQ_HOC_KY_MON_HOC)
                .WithRequired(e => e.HOCSINH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOCSINH>()
                .HasMany(e => e.PHANLOPs)
                .WithRequired(e => e.HOCSINH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KETQUA>()
                .Property(e => e.MaKetQua)
                .IsUnicode(false);

            modelBuilder.Entity<KETQUA>()
                .HasMany(e => e.KQ_CA_NAM_TONG_HOP)
                .WithRequired(e => e.KETQUA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KQ_CA_NAM_MON_HOC>()
                .Property(e => e.MaHocSinh)
                .IsUnicode(false);

            modelBuilder.Entity<KQ_CA_NAM_MON_HOC>()
                .Property(e => e.MaLop)
                .IsUnicode(false);

            modelBuilder.Entity<KQ_CA_NAM_MON_HOC>()
                .Property(e => e.MaMonHoc)
                .IsUnicode(false);

            modelBuilder.Entity<KQ_CA_NAM_MON_HOC>()
                .Property(e => e.MaNamHoc)
                .IsUnicode(false);

            modelBuilder.Entity<KQ_CA_NAM_TONG_HOP>()
                .Property(e => e.MaHocSinh)
                .IsUnicode(false);

            modelBuilder.Entity<KQ_CA_NAM_TONG_HOP>()
                .Property(e => e.MaLop)
                .IsUnicode(false);

            modelBuilder.Entity<KQ_CA_NAM_TONG_HOP>()
                .Property(e => e.MaNamHoc)
                .IsUnicode(false);

            modelBuilder.Entity<KQ_CA_NAM_TONG_HOP>()
                .Property(e => e.MaHocLuc)
                .IsUnicode(false);

            modelBuilder.Entity<KQ_CA_NAM_TONG_HOP>()
                .Property(e => e.MaHanhKiem)
                .IsUnicode(false);

            modelBuilder.Entity<KQ_CA_NAM_TONG_HOP>()
                .Property(e => e.MaKetQua)
                .IsUnicode(false);

            modelBuilder.Entity<KQ_HOC_KY_MON_HOC>()
                .Property(e => e.MaHocSinh)
                .IsUnicode(false);

            modelBuilder.Entity<KQ_HOC_KY_MON_HOC>()
                .Property(e => e.MaLop)
                .IsUnicode(false);

            modelBuilder.Entity<KQ_HOC_KY_MON_HOC>()
                .Property(e => e.MaMonHoc)
                .IsUnicode(false);

            modelBuilder.Entity<KQ_HOC_KY_MON_HOC>()
                .Property(e => e.MaHocKy)
                .IsUnicode(false);

            modelBuilder.Entity<KQ_HOC_KY_MON_HOC>()
                .Property(e => e.MaNamHoc)
                .IsUnicode(false);

            modelBuilder.Entity<KQ_HOC_KY_TONG_HOP>()
                .Property(e => e.MaHocSinh)
                .IsUnicode(false);

            modelBuilder.Entity<KQ_HOC_KY_TONG_HOP>()
                .Property(e => e.MaLop)
                .IsUnicode(false);

            modelBuilder.Entity<KQ_HOC_KY_TONG_HOP>()
                .Property(e => e.MaHocKy)
                .IsUnicode(false);

            modelBuilder.Entity<KQ_HOC_KY_TONG_HOP>()
                .Property(e => e.MaNamHoc)
                .IsUnicode(false);

            modelBuilder.Entity<KQ_HOC_KY_TONG_HOP>()
                .Property(e => e.MaHocLuc)
                .IsUnicode(false);

            modelBuilder.Entity<KQ_HOC_KY_TONG_HOP>()
                .Property(e => e.MaHanhKiem)
                .IsUnicode(false);

            modelBuilder.Entity<KHOILOP>()
                .Property(e => e.MaKhoiLop)
                .IsUnicode(false);

            modelBuilder.Entity<KHOILOP>()
                .HasMany(e => e.LOPs)
                .WithRequired(e => e.KHOILOP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHOILOP>()
                .HasMany(e => e.PHANLOPs)
                .WithRequired(e => e.KHOILOP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIDIEM>()
                .Property(e => e.MaLoai)
                .IsUnicode(false);

            modelBuilder.Entity<LOAIDIEM>()
                .HasMany(e => e.DIEMs)
                .WithRequired(e => e.LOAIDIEM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAINGUOIDUNG>()
                .Property(e => e.MaLoai)
                .IsUnicode(false);

            modelBuilder.Entity<LOAINGUOIDUNG>()
                .HasMany(e => e.NGUOIDUNGs)
                .WithRequired(e => e.LOAINGUOIDUNG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOP>()
                .Property(e => e.MaLop)
                .IsUnicode(false);

            modelBuilder.Entity<LOP>()
                .Property(e => e.MaKhoiLop)
                .IsUnicode(false);

            modelBuilder.Entity<LOP>()
                .Property(e => e.MaNamHoc)
                .IsUnicode(false);

            modelBuilder.Entity<LOP>()
                .Property(e => e.MaGiaoVien)
                .IsUnicode(false);

            modelBuilder.Entity<LOP>()
                .HasMany(e => e.DIEMs)
                .WithRequired(e => e.LOP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOP>()
                .HasMany(e => e.KQ_CA_NAM_MON_HOC)
                .WithRequired(e => e.LOP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOP>()
                .HasMany(e => e.KQ_CA_NAM_TONG_HOP)
                .WithRequired(e => e.LOP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOP>()
                .HasMany(e => e.KQ_HOC_KY_MON_HOC)
                .WithRequired(e => e.LOP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOP>()
                .HasMany(e => e.KQ_HOC_KY_TONG_HOP)
                .WithRequired(e => e.LOP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOP>()
                .HasMany(e => e.PHANLOPs)
                .WithRequired(e => e.LOP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOP>()
                .HasMany(e => e.PHANCONGs)
                .WithRequired(e => e.LOP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MONHOC>()
                .Property(e => e.MaMonHoc)
                .IsUnicode(false);

            modelBuilder.Entity<MONHOC>()
                .HasMany(e => e.DIEMs)
                .WithRequired(e => e.MONHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MONHOC>()
                .HasMany(e => e.GIAOVIENs)
                .WithRequired(e => e.MONHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MONHOC>()
                .HasMany(e => e.KQ_CA_NAM_MON_HOC)
                .WithRequired(e => e.MONHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MONHOC>()
                .HasMany(e => e.KQ_HOC_KY_MON_HOC)
                .WithRequired(e => e.MONHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MONHOC>()
                .HasMany(e => e.PHANCONGs)
                .WithRequired(e => e.MONHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NAMHOC>()
                .Property(e => e.MaNamHoc)
                .IsUnicode(false);

            modelBuilder.Entity<NAMHOC>()
                .Property(e => e.TenNamHoc)
                .IsUnicode(false);

            modelBuilder.Entity<NAMHOC>()
                .HasMany(e => e.DIEMs)
                .WithRequired(e => e.NAMHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NAMHOC>()
                .HasMany(e => e.KQ_CA_NAM_MON_HOC)
                .WithRequired(e => e.NAMHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NAMHOC>()
                .HasMany(e => e.KQ_CA_NAM_TONG_HOP)
                .WithRequired(e => e.NAMHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NAMHOC>()
                .HasMany(e => e.KQ_HOC_KY_MON_HOC)
                .WithRequired(e => e.NAMHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NAMHOC>()
                .HasMany(e => e.KQ_HOC_KY_TONG_HOP)
                .WithRequired(e => e.NAMHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NAMHOC>()
                .HasMany(e => e.LOPs)
                .WithRequired(e => e.NAMHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NAMHOC>()
                .HasMany(e => e.PHANCONGs)
                .WithRequired(e => e.NAMHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NAMHOC>()
                .HasMany(e => e.PHANLOPs)
                .WithRequired(e => e.NAMHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NGHENGHIEP>()
                .Property(e => e.MaNghe)
                .IsUnicode(false);

            modelBuilder.Entity<NGHENGHIEP>()
                .HasMany(e => e.HOCSINHs)
                .WithRequired(e => e.NGHENGHIEP)
                .HasForeignKey(e => e.MaNNghiepCha)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NGHENGHIEP>()
                .HasMany(e => e.HOCSINHs1)
                .WithRequired(e => e.NGHENGHIEP1)
                .HasForeignKey(e => e.MaNNghiepMe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.MaND)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.MaLoai)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.TenDNhap)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<PHANCONG>()
                .Property(e => e.MaNamHoc)
                .IsUnicode(false);

            modelBuilder.Entity<PHANCONG>()
                .Property(e => e.MaLop)
                .IsUnicode(false);

            modelBuilder.Entity<PHANCONG>()
                .Property(e => e.MaMonHoc)
                .IsUnicode(false);

            modelBuilder.Entity<PHANCONG>()
                .Property(e => e.MaGiaoVien)
                .IsUnicode(false);

            modelBuilder.Entity<PHANLOP>()
                .Property(e => e.MaNamHoc)
                .IsUnicode(false);

            modelBuilder.Entity<PHANLOP>()
                .Property(e => e.MaKhoiLop)
                .IsUnicode(false);

            modelBuilder.Entity<PHANLOP>()
                .Property(e => e.MaLop)
                .IsUnicode(false);

            modelBuilder.Entity<PHANLOP>()
                .Property(e => e.MaHocSinh)
                .IsUnicode(false);

            modelBuilder.Entity<TONGIAO>()
                .Property(e => e.MaTonGiao)
                .IsUnicode(false);

            modelBuilder.Entity<TONGIAO>()
                .HasMany(e => e.HOCSINHs)
                .WithRequired(e => e.TONGIAO)
                .WillCascadeOnDelete(false);
        }
    }
}
