namespace OnlShoe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sanpham")]
    public partial class Sanpham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sanpham()
        {
            Chitietdonhang = new HashSet<Chitietdonhang>();
        }

        [Key]
        public int Masp { get; set; }

        [StringLength(50)]
        public string Tensp { get; set; }

        public decimal? Giatien { get; set; }

        [StringLength(50)]
        public string Kichthuoc { get; set; }

        [StringLength(500)]
        public string Anhbia { get; set; }

        [StringLength(50)]
        public string Loai { get; set; }

        public int? Mahang { get; set; }
        public int? Soluong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitietdonhang> Chitietdonhang { get; set; }

        public virtual Hangsanxuat Hangsanxuat { get; set; }
    }
}
