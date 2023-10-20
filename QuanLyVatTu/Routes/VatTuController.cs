using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using app.Models;
using Microsoft.AspNetCore.Authorization;
using System.Text.Json;


namespace app.Routes;
// [ApiController]
[Route("vat-tu")]
public class VatTuController : Controller
{
    private ApplicationDbContext dbContext;
    public VatTuController(ApplicationDbContext dbContext){
        this.dbContext = dbContext;
    }
    // [Authorize(Roles = "ADMIN,USER")]
    public ActionResult Index(){
        var listVatTu = dbContext.VatTu.ToList();
        ViewBag.result = listVatTu;
        return View();
    }
}
