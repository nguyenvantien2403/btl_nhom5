using CoffeeShopManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopManagement.Controllers
{
    public class AccessController : Controller
    {
        CoffeeShopManagementContext db = new CoffeeShopManagementContext();
        [HttpGet]

        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("UserName") == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }
        [HttpPost]
        public IActionResult Login(NguoiDung nguoidung)
        {
            if (HttpContext.Session.GetString("UserName") == null)
            {
                var u = db.NguoiDungs.Where(x => x.HoTen.Equals(nguoidung.HoTen) && x.MatKhau.Equals(nguoidung.MatKhau)).FirstOrDefault();
                if (u != null)
                {
                    HttpContext.Session.SetString("UserName", u.HoTen.ToString());
                    return RedirectToAction("Index", "Home");

                }

            }
            return View();
        }

    }
}
