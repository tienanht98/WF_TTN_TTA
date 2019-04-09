namespace WF_TTN_TTA.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MONHOC")]
    public partial class MONHOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MONHOC()
        {
            DIEMs = new HashSet<DIEM>();
            GIAOVIENs = new HashSet<GIAOVIEN>();
            KQ_CA_NAM_MON_HOC = new HashSet<KQ_CA_NAM_MON_HOC>();
            KQ_HOC_KY_MON_HOC = new HashSet<KQ_HOC_KY_MON_HOC>();
            PHANCONGs = new HashSet<PHANCONG>();
        }

        [Key]
        [StringLength(6)]
        public string MaMonHoc { get; set; }

        [Required]
        [StringLength(30)]
        public string TenMonHoc { get; set; }

        public int SoTiet { get; set; }

        public int HeSo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIEM> DIEMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIAOVIEN> GIAOVIENs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KQ_CA_NAM_MON_HOC> KQ_CA_NAM_MON_HOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KQ_HOC_KY_MON_HOC> KQ_HOC_KY_MON_HOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANCONG> PHANCONGs { get; set; }
    }
}
