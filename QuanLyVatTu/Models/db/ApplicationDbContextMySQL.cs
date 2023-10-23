using app.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;

public class ApplicationDbContextUsers : DbContext
{
     public ApplicationDbContextUsers(DbContextOptions<ApplicationDbContextUsers> options): base(options)
    {
    }
    // public virtual DbSet<User> Users{get;set;}


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured){
            
        }
    }
}