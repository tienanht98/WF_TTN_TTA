namespace WF_TTN_TTA.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOCLUC")]
    public partial class HOCLUC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOCLUC()
        {
            KQ_CA_NAM_TONG_HOP = new HashSet<KQ_CA_NAM_TONG_HOP>();
            KQ_HOC_KY_TONG_HOP = new HashSet<KQ_HOC_KY_TONG_HOP>();
        }

        [Key]
        [StringLength(6)]
        public string MaHocLuc { get; set; }

        [Required]
        [StringLength(30)]
        public string TenHocLuc { get; set; }

        public double DiemCanDuoi { get; set; }

        public double DiemCanTren { get; set; }

        public double DiemKhongChe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KQ_CA_NAM_TONG_HOP> KQ_CA_NAM_TONG_HOP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KQ_HOC_KY_TONG_HOP> KQ_HOC_KY_TONG_HOP { get; set; }
    }
}
