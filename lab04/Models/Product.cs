// ============================================================
// Lab 04 - Controller nang cao: Account/Profile + Route
// Sinh vien: Nguyen Van Hiep - MSSV: 2410900035 - Lop: K24CNT1
// Hoc phan: Phat trien ung dung voi cong nghe .NET
// ============================================================
using System;

namespace lab04.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public double PriceOld { get; set; }
        public int CategoryId { get; set; }
    }
}
