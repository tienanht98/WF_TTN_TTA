namespace WF_TTN_TTA.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KETQUA")]
    public partial class KETQUA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KETQUA()
        {
            KQ_CA_NAM_TONG_HOP = new HashSet<KQ_CA_NAM_TONG_HOP>();
        }

        [Key]
        [StringLength(6)]
        public string MaKetQua { get; set; }

        [Required]
        [StringLength(30)]
        public string TenKetQua { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KQ_CA_NAM_TONG_HOP> KQ_CA_NAM_TONG_HOP { get; set; }
    }
}
