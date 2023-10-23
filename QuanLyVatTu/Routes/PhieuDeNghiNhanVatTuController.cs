using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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

        public IActionResult Index()
        {
            return View();
        }
    }
}