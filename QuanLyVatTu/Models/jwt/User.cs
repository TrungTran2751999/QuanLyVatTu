using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models;
[Table("Users")]
public class User{
    [Key]
    [Column("Id")]
    public long IdSystem{get;set;}
    [Column("Guid")]
    public Guid? Guid{get;set;}
    [Column("UserName")]
    public string? Name{get;set;}
    [Column("Password")]
    public string? Password{get;set;}
    [Column("DepartmentId")]
    public long? DepartmentId{get;set;}
    [Column("MainDepartmentId")]
    public long? MainDepartmentId{get;set;}
    [Column("Email")]
    public string? Email{get;set;}

    [Column("Role")]
    public string? Role{get;set;}
    [Column("FullName")]
    public string? FullName{get;set;}
    [Column("FirstName")]
    public string? FirstName{get;set;}
    [Column("BirthDate")]
    public DateTime? BirthDate{get;set;}
    [Column("Gender")]
    public int? Gender{get;set;}
    [Column("Position")]
    public string? Position{get;set;}
    [Column("ShortPosition")]
    public string? ShortPosition{get;set;}
    [Column("PhoneNumber")]
    public string? PhoneNumber{get;set;}
    [Column("MobileNumber")]
    public string? MobileNumber{get;set;}
    [Column("EmployeeCode")]
    public string? EmployeeCode{get;set;}
    [Column("HrReferCode")]
    public string? HrReferCode{get;set;}
    [Column("Address")]
    public string? Address{get;set;}
    [Column("IsAttendanceTrack")]
    public bool? IsAttendanceTrack{get;set;}
    [Column("IsMettingManage")]
    public bool? IsMettingManage{get;set;}
    [Column("IsAdmin")]
    public bool? IsAdmin{get;set;}
    [Column("IsQLCLAdmin")]
    public bool? IsQLCLAdmin{get;set;}
    [Column("IsCNDHReporter")]
    public bool? IsCNDHReporter{get;set;}
    [Column("IsMeetingDocumentManage")]
    public bool? IsMeetingDocumentManage{get;set;}
    [Column("IsQLSXLichTrucManage")]
    public bool? IsQLSXLichTrucManage{get;set;}
    [Column("Mission")]
    public string? Mission{get;set;}
    [Column("Image")]
    public string? Image{get;set;}
    [Column("IsOnline")]
    public string? IsOnline{get;set;}
    [Column("IsLockedOut")]
    public bool? IsLockedOut{get;set;}
    [Column("CreationDate")]
    public DateTime? CreationDate{get;set;}
    [Column("LastActivityDate")]
    public DateTime? LastActivityDate{get;set;}
    [Column("AcademicLevel")]
    public string? AcademicLevel{get;set;}
    [Column("EducationSpecialized")]
    public string? EducationSpecialized{get;set;}
    [Column("LastPasswordChangedDate")]
    public DateTime? LastPasswordChangedDate{get;set;}
    [Column("IsRequiredChangePassword")]
    public bool? IsRequiredChangePassword{get;set;}
    [Column("DisplayOrder")]
    public int? DisplayOrder{get;set;}
    [Column("IsDeleted")]
    public bool? IsDeleted{get;set;}
    [Column("CreatedBy")]
    public long? CreatedBy{get;set;}
    [Column("CreatedTime")]
    public DateTime? CreatedTime{get;set;}
    [Column("UpdatedBy")]
    public long? UpdatedBy{get;set;}
    [Column("UpdatedTime")]
    public DateTime? UpdatedTime{get;set;}
    [Column("IsViewAllDocument")]
    public bool? IsViewAllDocument{get;set;}
    [Column("IsViewDraftDocument")]
    public bool? IsViewDraftDocument{get;set;}
    [Column("IsPMSAdmin")]
    public bool? IsPMSAdmin{get;set;}
    [Column("IsMeetingAdmin")]
    public bool? IsMeetingAdmin{get;set;}
    [Column("IsLDNReporter")]
    public bool? IsLDNReporter{get;set;}
}
