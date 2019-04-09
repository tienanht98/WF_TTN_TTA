namespace WF_TTN_TTA.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIAOVIEN")]
    public partial class GIAOVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIAOVIEN()
        {
            LOPs = new HashSet<LOP>();
            PHANCONGs = new HashSet<PHANCONG>();
        }

        [Key]
        [StringLength(6)]
        public string MaGiaoVien { get; set; }

        [Required]
        [StringLength(30)]
        public string TenGiaoVien { get; set; }

        [Required]
        [StringLength(50)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(15)]
        public string DienThoai { get; set; }

        [Required]
        [StringLength(6)]
        public string MaMonHoc { get; set; }

        public virtual MONHOC MONHOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOP> LOPs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANCONG> PHANCONGs { get; set; }
    }
}
