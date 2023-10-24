using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace app.DTOs;

public class NhaCungUngUpdateDTO{
    public long? Id{get;set;}
    [Required]
    public string? Name {get;set;}
    
}
