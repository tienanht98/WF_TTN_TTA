namespace WF_TTN_TTA.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOP")]
    public partial class LOP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOP()
        {
            DIEMs = new HashSet<DIEM>();
            KQ_CA_NAM_MON_HOC = new HashSet<KQ_CA_NAM_MON_HOC>();
            KQ_CA_NAM_TONG_HOP = new HashSet<KQ_CA_NAM_TONG_HOP>();
            KQ_HOC_KY_MON_HOC = new HashSet<KQ_HOC_KY_MON_HOC>();
            KQ_HOC_KY_TONG_HOP = new HashSet<KQ_HOC_KY_TONG_HOP>();
            PHANLOPs = new HashSet<PHANLOP>();
            PHANCONGs = new HashSet<PHANCONG>();
        }

        [Key]
        [StringLength(10)]
        public string MaLop { get; set; }

        [Required]
        [StringLength(30)]
        public string TenLop { get; set; }

        [Required]
        [StringLength(6)]
        public string MaKhoiLop { get; set; }

        [Required]
        [StringLength(6)]
        public string MaNamHoc { get; set; }

        public int SiSo { get; set; }

        [Required]
        [StringLength(6)]
        public string MaGiaoVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIEM> DIEMs { get; set; }

        public virtual GIAOVIEN GIAOVIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KQ_CA_NAM_MON_HOC> KQ_CA_NAM_MON_HOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KQ_CA_NAM_TONG_HOP> KQ_CA_NAM_TONG_HOP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KQ_HOC_KY_MON_HOC> KQ_HOC_KY_MON_HOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KQ_HOC_KY_TONG_HOP> KQ_HOC_KY_TONG_HOP { get; set; }

        public virtual KHOILOP KHOILOP { get; set; }

        public virtual NAMHOC NAMHOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANLOP> PHANLOPs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANCONG> PHANCONGs { get; set; }
    }
}
