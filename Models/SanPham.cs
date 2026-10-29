using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingWebTuan10.Models
{
    [Table("sanpham")]
    public class SanPham
    {
        [Key]
        [Column("ma")]
        [StringLength(20)]
        public string Ma { get; set; } = null!;

        [Column("ten")]
        [StringLength(100)]
        public string Ten { get; set; } = null!;

        [Column("gia")]
        public decimal? Gia { get; set; }

        [Column("danhmuc_ma")]
        [StringLength(20)]
        public string? DanhMucMa { get; set; }

        [ForeignKey(nameof(DanhMucMa))]
        public virtual DanhMuc? DanhMuc { get; set; }
    }
}