namespace WF_TTN_TTA.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DIEM")]
    public partial class DIEM
    {
        [Key]
        public int STT { get; set; }

        [Required]
        [StringLength(6)]
        public string MaHocSinh { get; set; }

        [Required]
        [StringLength(6)]
        public string MaMonHoc { get; set; }

        [Required]
        [StringLength(3)]
        public string MaHocKy { get; set; }

        [Required]
        [StringLength(6)]
        public string MaNamHoc { get; set; }

        [Required]
        [StringLength(10)]
        public string MaLop { get; set; }

        [Required]
        [StringLength(6)]
        public string MaLoai { get; set; }

        [Column("Diem")]
        public double Diem1 { get; set; }

        public virtual HOCKY HOCKY { get; set; }

        public virtual HOCSINH HOCSINH { get; set; }

        public virtual LOAIDIEM LOAIDIEM { get; set; }

        public virtual LOP LOP { get; set; }

        public virtual MONHOC MONHOC { get; set; }

        public virtual NAMHOC NAMHOC { get; set; }
    }
}
