using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models;
[Table("NhaCungUng_VatTu")]
public class NhaCungUngVatTu{
    [Key]
    [Column("Id")]
    public long Id{get;set;}
    [Required]
    [Column("Guid")]
    public Guid? Guid{set;get;}
    [Required]
    [Column("TenNhaCungUng")]
    public string? TenNhaCungUng{set;get;}
    [Required]
    [Column("CreatedAt")]
    public DateTime? CreatedAt{set;get;}
    [Required]
    [Column("CreatedBy")]
    public long? CreatedBy{set;get;}
    [Required]
    [Column("UpdateAt")]
    public DateTime? UpdateAt{set;get;}
    [Required]
    [Column("UpdateBy")]
    public long? UpdateBy{set;get;}
}
