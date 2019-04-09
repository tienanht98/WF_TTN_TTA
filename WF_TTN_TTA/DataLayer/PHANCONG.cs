namespace WF_TTN_TTA.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHANCONG")]
    public partial class PHANCONG
    {
        [Key]
        public int STT { get; set; }

        [Required]
        [StringLength(6)]
        public string MaNamHoc { get; set; }

        [Required]
        [StringLength(10)]
        public string MaLop { get; set; }

        [Required]
        [StringLength(6)]
        public string MaMonHoc { get; set; }

        [Required]
        [StringLength(6)]
        public string MaGiaoVien { get; set; }

        public virtual GIAOVIEN GIAOVIEN { get; set; }

        public virtual LOP LOP { get; set; }

        public virtual MONHOC MONHOC { get; set; }

        public virtual NAMHOC NAMHOC { get; set; }
    }
}
