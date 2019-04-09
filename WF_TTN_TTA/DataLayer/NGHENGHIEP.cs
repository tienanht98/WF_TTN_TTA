namespace WF_TTN_TTA.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGHENGHIEP")]
    public partial class NGHENGHIEP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGHENGHIEP()
        {
            HOCSINHs = new HashSet<HOCSINH>();
            HOCSINHs1 = new HashSet<HOCSINH>();
        }

        [Key]
        [StringLength(6)]
        public string MaNghe { get; set; }

        [Required]
        [StringLength(30)]
        public string TenNghe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOCSINH> HOCSINHs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOCSINH> HOCSINHs1 { get; set; }
    }
}
