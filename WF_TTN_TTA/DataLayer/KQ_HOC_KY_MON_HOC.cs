namespace WF_TTN_TTA.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KQ_HOC_KY_MON_HOC
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string MaHocSinh { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaLop { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string MaMonHoc { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string MaHocKy { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(6)]
        public string MaNamHoc { get; set; }

        public double DTBKiemTra { get; set; }

        public double DTBMonHocKy { get; set; }

        public virtual HOCKY HOCKY { get; set; }

        public virtual HOCSINH HOCSINH { get; set; }

        public virtual LOP LOP { get; set; }

        public virtual MONHOC MONHOC { get; set; }

        public virtual NAMHOC NAMHOC { get; set; }
    }
}
