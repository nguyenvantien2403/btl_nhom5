namespace CoffeeShopManagement.Models.SanPhamAPI
{
    public class Sanpham
    {
        public string IdSanPham { get; set; } = null!;

        public string? TenSanPham { get; set; }

        public decimal? GiaTien { get; set; }

        public string IdMenu { get; set; } = null!;

        public string? Images { get; set; }
    }
}
