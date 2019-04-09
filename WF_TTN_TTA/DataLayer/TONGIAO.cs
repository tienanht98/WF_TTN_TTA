namespace WF_TTN_TTA.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TONGIAO")]
    public partial class TONGIAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TONGIAO()
        {
            HOCSINHs = new HashSet<HOCSINH>();
        }

        [Key]
        [StringLength(6)]
        public string MaTonGiao { get; set; }

        [Required]
        [StringLength(30)]
        public string TenTonGiao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOCSINH> HOCSINHs { get; set; }
    }
}
