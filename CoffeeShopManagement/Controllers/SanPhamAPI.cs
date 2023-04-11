using CoffeeShopManagement.Models;
using Microsoft.AspNetCore.Mvc;
using CoffeeShopManagement.Models.SanPhamAPI;
namespace CoffeeShopManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamAPI : ControllerBase
    {
        CoffeeShopManagementContext db = new CoffeeShopManagementContext();
        public IEnumerable<Sanpham> getAllSanPham()
        {
            var Sanpham = (from p in db.SanPhams
                              select new Sanpham
                              {
                                  IdSanPham = p.IdSanPham,
                                  TenSanPham = p.TenSanPham,
                                  GiaTien = p.GiaTien,
                                  IdMenu = p.IdMenu,
                                  Images = p.Images
                              }).ToList();
            return Sanpham;
        }
        [HttpGet("{maMenu}")]
        public IEnumerable<Sanpham> getSanPhamFromMenu(string maMenu)
        {
            var Sanpham = (from p in db.SanPhams
                           where p.IdMenu == maMenu
                           select new Sanpham
                           {
                               IdSanPham = p.IdSanPham,
                               TenSanPham = p.TenSanPham,
                               GiaTien = p.GiaTien,
                               IdMenu = p.IdMenu,
                               Images = p.Images
                           }).ToList();
            return Sanpham;
        }
    }

}
