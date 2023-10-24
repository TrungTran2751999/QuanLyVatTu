using app.DTOs;
using app.Models;
using Microsoft.AspNetCore.Mvc;

namespace app.Services;

public interface INhaCungUngService{
    Task<List<NhaCungUngVatTu>?> GetAll();
    Task<NhaCungUngVatTu?> GetById(long id);
    Task<bool?> Save(NhaCungUngCreateDTO nhaCungUngCreate);
    Task<NhaCungUngVatTu?> Update(NhaCungUngUpdateDTO nhaCungUngUpdate);
}