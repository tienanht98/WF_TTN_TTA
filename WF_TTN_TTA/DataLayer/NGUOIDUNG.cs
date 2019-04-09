namespace WF_TTN_TTA.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGUOIDUNG")]
    public partial class NGUOIDUNG
    {
        [Key]
        [StringLength(6)]
        public string MaND { get; set; }

        [Required]
        [StringLength(6)]
        public string MaLoai { get; set; }

        [Required]
        [StringLength(30)]
        public string TenND { get; set; }

        [Required]
        [StringLength(30)]
        public string TenDNhap { get; set; }

        [Required]
        [StringLength(30)]
        public string MatKhau { get; set; }

        public virtual LOAINGUOIDUNG LOAINGUOIDUNG { get; set; }
    }
}
