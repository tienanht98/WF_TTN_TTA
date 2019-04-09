namespace WF_TTN_TTA.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOCSINH")]
    public partial class HOCSINH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOCSINH()
        {
            DIEMs = new HashSet<DIEM>();
            KQ_CA_NAM_TONG_HOP = new HashSet<KQ_CA_NAM_TONG_HOP>();
            KQ_CA_NAM_MON_HOC = new HashSet<KQ_CA_NAM_MON_HOC>();
            KQ_HOC_KY_TONG_HOP = new HashSet<KQ_HOC_KY_TONG_HOP>();
            KQ_HOC_KY_MON_HOC = new HashSet<KQ_HOC_KY_MON_HOC>();
            PHANLOPs = new HashSet<PHANLOP>();
        }

        [Key]
        [StringLength(6)]
        public string MaHocSinh { get; set; }

        [Required]
        [StringLength(30)]
        public string HoTen { get; set; }

        public bool? GioiTinh { get; set; }

        public DateTime? NgaySinh { get; set; }

        [Required]
        [StringLength(50)]
        public string NoiSinh { get; set; }

        [Required]
        [StringLength(6)]
        public string MaDanToc { get; set; }

        [Required]
        [StringLength(6)]
        public string MaTonGiao { get; set; }

        [Required]
        [StringLength(30)]
        public string HoTenCha { get; set; }

        [Required]
        [StringLength(6)]
        public string MaNNghiepCha { get; set; }

        [Required]
        [StringLength(30)]
        public string HoTenMe { get; set; }

        [Required]
        [StringLength(6)]
        public string MaNNghiepMe { get; set; }

        public virtual DANTOC DANTOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIEM> DIEMs { get; set; }

        public virtual NGHENGHIEP NGHENGHIEP { get; set; }

        public virtual NGHENGHIEP NGHENGHIEP1 { get; set; }

        public virtual TONGIAO TONGIAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KQ_CA_NAM_TONG_HOP> KQ_CA_NAM_TONG_HOP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KQ_CA_NAM_MON_HOC> KQ_CA_NAM_MON_HOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KQ_HOC_KY_TONG_HOP> KQ_HOC_KY_TONG_HOP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KQ_HOC_KY_MON_HOC> KQ_HOC_KY_MON_HOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANLOP> PHANLOPs { get; set; }
    }
}
