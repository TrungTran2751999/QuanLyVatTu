using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using app.Models;
namespace app.DTOs;

public class NhaCungUngCreateDTO{
    public string? Name {get;set;}
    public long? CreatedBy{get;set;}
    public long? UpdateBy{get;set;}

    public NhaCungUngVatTu ToModel(){
        NhaCungUngVatTu nhaCungUngVatTu = new NhaCungUngVatTu();
        nhaCungUngVatTu.TenNhaCungUng = Name;
        nhaCungUngVatTu.CreatedBy = CreatedBy;
        nhaCungUngVatTu.UpdateBy = UpdateBy;
        nhaCungUngVatTu.CreatedAt = DateTime.Now;
        nhaCungUngVatTu.UpdateAt = DateTime.Now;
        nhaCungUngVatTu.Guid = Guid.NewGuid();
        return nhaCungUngVatTu;
    } 
    
}
