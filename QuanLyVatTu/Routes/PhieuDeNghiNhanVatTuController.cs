using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using app.Models;
using app.DTOs;
using Org.BouncyCastle.Asn1.Ocsp;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace QuanLyVatTu.Routes
{
    [Route("")]
    public class PhieuDeNghiNhanVatTuController : Controller
    {
        private ApplicationDbContextUsers applicationDbContextUsers;
        private ApplicationDbContext applicationDbContext;

        public PhieuDeNghiNhanVatTuController(ApplicationDbContextUsers applicationDbContextUsers, ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContextUsers = applicationDbContextUsers;
            this.applicationDbContext = applicationDbContext;
        }
        public IActionResult Index(int id)
        {

            var listPhieu = applicationDbContext.PhieuNhanVatTu.Select(t=>new{
                Id = t.Id,
                Guid = t.Guid,
                MaNguoiNhan = t.MaNguoiNhan,
                TenNguoiNhan = t.TenNguoiNhan,
                LyDoNhan = t.LyDoNhan
            }).Skip(id).Take(10).ToArray();
            List<long> listMaNguoiNhan = new List<long>();
            for(int i=0; i<listPhieu.Length; i++){
                
            }
            var users = applicationDbContextUsers.Users.Select(t=>new{
                Id = t.Id
            }).ToArray();
            
            ViewBag.result = listPhieu;

            return View();
        }
    }
}