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
    // public virtual DbSet<User> Users{get;set;}


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured){
            
        }
    }
}