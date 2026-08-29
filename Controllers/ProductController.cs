// ============================================================
// Lab 04 - Controller nang cao: Account/Profile + Route
// Sinh vien: Nguyen Van Hiep - MSSV: 2410900035 - Lop: K24CNT1
// Hoc phan: Phat trien ung dung voi cong nghe .NET
// ============================================================
using Microsoft.AspNetCore.Mvc;
using lab04.Models;
using System.Collections.Generic;
using System.Linq;

namespace lab04.Controllers
{
    // Đổi route mặc định /Product thành /san-pham
    [Route("san-pham")]
    public class ProductController : Controller
    {
        // Danh sách danh mục
        private List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category() { Id = 1, Name = "Quần Áo" },
                new Category() { Id = 2, Name = "Đồng hồ" },
                new Category() { Id = 3, Name = "Tivi" },
                new Category() { Id = 4, Name = "Máy bơm" },
                new Category() { Id = 5, Name = "Quạt điện" },
                new Category() { Id = 6, Name = "Lò sưởi" },
                new Category() { Id = 7, Name = "Bộ đồ bơi cho trẻ em" }
            };
        }

        // Danh sách sản phẩm (mock data)
        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product() { Id = 1, Name = "Bộ đồ bơi cho trẻ em nam", CategoryId = 7, Price = 50000, PriceOld = 35000, Image = Url.Content("~/images/Product/p1.png"), Description = "Bộ đồ bơi cho trẻ em nam, chất liệu co giãn, thoáng mát, an toàn cho da bé." },
                new Product() { Id = 2, Name = "Bộ đồ bơi cho trẻ em nữ", CategoryId = 7, Price = 50000, PriceOld = 35000, Image = Url.Content("~/images/Product/p2.png"), Description = "Bộ đồ bơi cho trẻ em nữ, màu sắc tươi sáng, kiểu dáng xinh xắn." },
                new Product() { Id = 3, Name = "Bộ đồ bơi cho trẻ em từ 3-5 tuổi", CategoryId = 7, Price = 50000, PriceOld = 35000, Image = Url.Content("~/images/Product/p3.png"), Description = "Bộ đồ bơi cho trẻ em từ 3-5 tuổi, phù hợp cho bé tập bơi." },
                new Product() { Id = 4, Name = "Túi thời trang da cá sấu", CategoryId = 1, Price = 60000, PriceOld = 35000, Image = Url.Content("~/images/Product/p4.png"), Description = "Túi thời trang da cá sấu, phong cách mới 2021, sang trọng và đẳng cấp." },
                new Product() { Id = 5, Name = "Túi thời trang màu", CategoryId = 1, Price = 60000, PriceOld = 35000, Image = Url.Content("~/images/Product/p5.png"), Description = "Túi thời trang màu sắc trẻ trung, phù hợp đi làm, đi chơi." },
                new Product() { Id = 6, Name = "Đồng hồ nam cao cấp", CategoryId = 2, Price = 1500000, PriceOld = 1200000, Image = Url.Content("~/images/Product/p6.png"), Description = "Đồng hồ nam cao cấp, mặt kính chống xước, dây thép không gỉ." },
                new Product() { Id = 7, Name = "Tivi LED 55 inch", CategoryId = 3, Price = 12500000, PriceOld = 11000000, Image = Url.Content("~/images/Product/p7.png"), Description = "Tivi LED 55 inch, hình ảnh sắc nét, âm thanh sống động, kết nối thông minh." },
                new Product() { Id = 8, Name = "Máy bơm nước", CategoryId = 4, Price = 850000, PriceOld = 700000, Image = Url.Content("~/images/Product/p8.png"), Description = "Máy bơm nước công suất lớn, hoạt động bền bỉ, tiết kiệm điện." },
                new Product() { Id = 9, Name = "Quạt điện cây", CategoryId = 5, Price = 650000, PriceOld = 500000, Image = Url.Content("~/images/Product/p9.png"), Description = "Quạt điện cây, gió mạnh, êm ái, điều khiển từ xa." },
                new Product() { Id = 10, Name = "Lò sưởi điện", CategoryId = 6, Price = 950000, PriceOld = 800000, Image = Url.Content("~/images/Product/p10.png"), Description = "Lò sưởi điện, sưởi ấm nhanh, an toàn, tiết kiệm điện." }
            };
        }

        // Hiển thị danh sách sản phẩm (có thể lọc theo danh mục)
        [HttpGet("")]
        public IActionResult Index(int? categoryId)
        {
            List<Category> categories = GetCategories();
            List<Product> products = GetProducts();

            // Khi click vào từng danh mục bên trái thì hiển thị các sản phẩm của danh mục đó
            if (categoryId.HasValue && categoryId.Value > 0)
            {
                products = products.Where(p => p.CategoryId == categoryId.Value).ToList();
            }

            ViewBag.Categories = categories;
            ViewBag.Products = products;
            ViewBag.CurrentCategoryId = categoryId ?? 0;
            return View();
        }

        // Khi click vào nút chi tiết sẽ hiển thị chi tiết sản phẩm đó theo id trên url
        [HttpGet("chi-tiet/{id:int}")]
        public IActionResult Detail(int id)
        {
            List<Product> products = GetProducts();
            Product product = products.FirstOrDefault(p => p.Id == id);

            ViewBag.Product = product;
            return View();
        }
    }
}
