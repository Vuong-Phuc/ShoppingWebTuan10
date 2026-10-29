using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingWebTuan10.Models
{
    [Table("danhmuc")]
    public class DanhMuc
    {
        [Key]
        [Column("ma")]
        [StringLength(20)]
        public string Ma { get; set; } = null!;

        [Column("ten")]
        [StringLength(100)]
        public string Ten { get; set; } = null!;

        public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
    }
}