namespace WF_TTN_TTA.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NAMHOC")]
    public partial class NAMHOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NAMHOC()
        {
            DIEMs = new HashSet<DIEM>();
            KQ_CA_NAM_MON_HOC = new HashSet<KQ_CA_NAM_MON_HOC>();
            KQ_CA_NAM_TONG_HOP = new HashSet<KQ_CA_NAM_TONG_HOP>();
            KQ_HOC_KY_MON_HOC = new HashSet<KQ_HOC_KY_MON_HOC>();
            KQ_HOC_KY_TONG_HOP = new HashSet<KQ_HOC_KY_TONG_HOP>();
            LOPs = new HashSet<LOP>();
            PHANCONGs = new HashSet<PHANCONG>();
            PHANLOPs = new HashSet<PHANLOP>();
        }

        [Key]
        [StringLength(6)]
        public string MaNamHoc { get; set; }

        [Required]
        [StringLength(30)]
        public string TenNamHoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIEM> DIEMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KQ_CA_NAM_MON_HOC> KQ_CA_NAM_MON_HOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KQ_CA_NAM_TONG_HOP> KQ_CA_NAM_TONG_HOP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KQ_HOC_KY_MON_HOC> KQ_HOC_KY_MON_HOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KQ_HOC_KY_TONG_HOP> KQ_HOC_KY_TONG_HOP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOP> LOPs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANCONG> PHANCONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANLOP> PHANLOPs { get; set; }
    }
}
