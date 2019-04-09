namespace WF_TTN_TTA.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHANLOP")]
    public partial class PHANLOP
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string MaNamHoc { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string MaKhoiLop { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string MaLop { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(6)]
        public string MaHocSinh { get; set; }

        public virtual HOCSINH HOCSINH { get; set; }

        public virtual KHOILOP KHOILOP { get; set; }

        public virtual LOP LOP { get; set; }

        public virtual NAMHOC NAMHOC { get; set; }
    }
}
