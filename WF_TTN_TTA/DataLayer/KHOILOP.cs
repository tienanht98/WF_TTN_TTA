namespace WF_TTN_TTA.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHOILOP")]
    public partial class KHOILOP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHOILOP()
        {
            LOPs = new HashSet<LOP>();
            PHANLOPs = new HashSet<PHANLOP>();
        }

        [Key]
        [StringLength(6)]
        public string MaKhoiLop { get; set; }

        [Required]
        [StringLength(30)]
        public string TenKhoiLop { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOP> LOPs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANLOP> PHANLOPs { get; set; }
    }
}
