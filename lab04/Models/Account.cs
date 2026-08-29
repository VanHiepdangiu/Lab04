// ============================================================
// Lab 04 - Controller nang cao: Account/Profile + Route
// Sinh vien: Nguyen Van Hiep - MSSV: 2410900035 - Lop: K24CNT1
// Hoc phan: Phat trien ung dung voi cong nghe .NET
// ============================================================
using System;

namespace lab04.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Avatar { get; set; }
        public string Address { get; set; }
        public string Bio { get; set; }
        public int Gender { get; set; }
        public DateTime Birthday { get; set; }
    }
}
