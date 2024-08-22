using Assingment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Assingment.Controllers
{ 
    public class HomeController : Controller
    {
        QLBanVaLiContext db = new QLBanVaLiContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult SanPhamTheoLoai(String maloai)
        {
            List<TDanhMucSp> lstsanpham=db.TDanhMucSps.Where(x=>x.MaLoai==maloai).OrderBy(x=>x.TenSp).ToList();
            return View(lstsanpham);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
