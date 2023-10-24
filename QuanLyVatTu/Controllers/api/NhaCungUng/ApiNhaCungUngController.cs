using app.DTOs;
using app.Models;
using app.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace app.Controllers;

[ApiController]
[Route("api/nha-cung-ung")]
public class ApiNhaCungUngController:Controller{
    private INhaCungUngService NhaCungUngService;
    public ApiNhaCungUngController(INhaCungUngService NhaCungUngService){
        this.NhaCungUngService = NhaCungUngService;
    }
    // [Authorize(Roles = "ADMIN,USER")]
    public async Task<IActionResult> GetAll(){
        var nhaCungUng = await NhaCungUngService.GetAll();
        return Ok(nhaCungUng);
    }
    [Route("{id}")]
    public async Task<IActionResult> GetById(long id){
        var nhaCungUng = await NhaCungUngService.GetById(id);
        return Ok(nhaCungUng);
    }

    // [Authorize(Roles = "ADMIN,USER")]
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] NhaCungUngCreateDTO nhaCungUng){
        Console.WriteLine(nhaCungUng.Name);
        var result = await NhaCungUngService.Save(nhaCungUng);
        if(result==false){
            return BadRequest();
        }
        return Ok(result);
    }

    [HttpPut]
    // [Authorize(Roles = "ADMIN")]
    public async Task<IActionResult> Update([FromBody] NhaCungUngUpdateDTO nhaCungUng){
        var result = await NhaCungUngService.Update(nhaCungUng);
        if(result==null){
            return BadRequest();
        }
        return Ok(result);
    }
}