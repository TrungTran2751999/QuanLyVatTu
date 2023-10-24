using app.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;

public class ApplicationDbContext : DbContext
{
     public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
    }
    public virtual DbSet<NhomVatTu> NhomVatTu{get;set;}
    public virtual DbSet<VatTu> VatTu{get;set;}
    public virtual DbSet<NhaCungUngVatTu> NhaCungUng{get;set;}

    public virtual DbSet<PhieuNhanVatTu> PhieuNhanVatTu{get;set;}
    public virtual DbSet<PhieuNhanVatTuChiTiet> PhieuNhanVatTuChiTiet{get;set;}



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured){
            
        }
    }
}