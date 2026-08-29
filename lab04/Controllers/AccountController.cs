// ============================================================
// Lab 04 - Controller nang cao: Account/Profile + Route
// Sinh vien: Nguyen Van Hiep - MSSV: 2410900035 - Lop: K24CNT1
// Hoc phan: Phat trien ung dung voi cong nghe .NET
// ============================================================
using Microsoft.AspNetCore.Mvc;
using lab04.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace lab04.Controllers
{
    public class AccountController : Controller
    {
        // Danh sách Account (dữ liệu cũ — mock data theo source thầy)
        private List<Account> GetAccounts()
        {
            return new List<Account>
            {
                new Account()
                {
                    Id = 1,
                    Name = "Nguyen Van Hiep",
                    Email = "hiep2410900035@gmail.com",
                    Phone = "0988089376",
                    Address = "Ha Noi",
                    Avatar = Url.Content("~/Avatar/02.png"),
                    Gender = 1,
                    Bio = "Sinh vien K24CNT1 - MSSV: 2410900035",
                    Birthday = new DateTime(2006, 9, 27)
                },
                new Account()
                {
                    Id = 2,
                    Name = "Truong Giang",
                    Email = "giang@gmail.com",
                    Phone = "0986456789",
                    Address = "Ha Noi",
                    Avatar = Url.Content("~/Avatar/03.png"),
                    Gender = 1,
                    Bio = "My name is small",
                    Birthday = new DateTime(1998, 7, 15)
                },
                new Account()
                {
                    Id = 3,
                    Name = "Hoang Thuy",
                    Email = "thuy@gmail.com",
                    Phone = "0986456789",
                    Address = "Ha Noi",
                    Avatar = Url.Content("~/Avatar/04.png"),
                    Gender = 0,
                    Bio = "My name is small",
                    Birthday = new DateTime(1998, 7, 15)
                }
            };
        }

        // Hiển thị danh sách các account có đăng ký
        public IActionResult Index()
        {
            List<Account> accounts = GetAccounts();

            // Gửi danh sách account qua view
            ViewBag.Accounts = accounts;
            return View();
        }

        // Định nghĩa url và tên cho action
        [Route("ho-so-cua-toi/{id?}", Name = "profile")]
        public IActionResult Profile(int id)
        {
            // Danh sách Account như trên Action Index
            List<Account> accounts = GetAccounts();

            // LINQ truy xuất dữ liệu 1 đối tượng trong danh sách theo Id
            Account account = accounts.FirstOrDefault(ac => ac.Id == id);

            // Gửi đối tượng account qua view
            ViewBag.account = account;
            return View();
        }
    }
}
