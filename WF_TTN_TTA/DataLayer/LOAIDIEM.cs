namespace WF_TTN_TTA.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIDIEM")]
    public partial class LOAIDIEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIDIEM()
        {
            DIEMs = new HashSet<DIEM>();
        }

        [Key]
        [StringLength(6)]
        public string MaLoai { get; set; }

        [Required]
        [StringLength(30)]
        public string TenLoai { get; set; }

        public int HeSo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIEM> DIEMs { get; set; }
    }
}
