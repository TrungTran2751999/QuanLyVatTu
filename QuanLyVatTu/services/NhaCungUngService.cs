using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using app.Models;
using app.Services;
using app.DTOs;
using Microsoft.EntityFrameworkCore;
namespace app.Services;
public class NhaCungUngService : INhaCungUngService
{
    private readonly ApplicationDbContext dbContext;

    public NhaCungUngService(ApplicationDbContext dbContext){
        this.dbContext = dbContext;
    }

    public async Task<List<NhaCungUngVatTu>?> GetAll()
    {
        var nhaCungUng = await dbContext.NhaCungUng.ToListAsync();
        return nhaCungUng;
    }

    public async Task<NhaCungUngVatTu?> GetById(long id)
    {
        var nhaCungUng = await dbContext.NhaCungUng.FirstOrDefaultAsync(param=>param.Id==id);
        return nhaCungUng;
    }

    public async Task<bool?> Save(NhaCungUngCreateDTO nhaCungUngCreate)
    {
        // long maxId = 0;
        var maxId =  await dbContext.NhaCungUng.MaxAsync(x=>x.Id);
        Console.WriteLine(maxId);
        // try{
        //     maxId = await dbContext.NhaCungUng.MaxAsync(x=>x.Id);            
        // }catch(Exception e){
        //     maxId = 0;
        // }
        NhaCungUngVatTu nhaCungUng = nhaCungUngCreate.ToModel();
        nhaCungUng.Id = maxId+1;
        await dbContext.NhaCungUng.AddAsync(nhaCungUng);
        dbContext.SaveChanges();
        return true;
        
    }

    public async Task<NhaCungUngVatTu?> Update(NhaCungUngUpdateDTO nhaCungUngUpdate)
    {
        var nhaCungUng = await dbContext.NhaCungUng.FirstOrDefaultAsync(x=>x.Id==nhaCungUngUpdate.Id);
        if(nhaCungUng!=null) return null;
        nhaCungUng.TenNhaCungUng = nhaCungUngUpdate.Name;
        dbContext.SaveChanges();
        return nhaCungUng;
    }
}