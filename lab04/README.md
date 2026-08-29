# Lab 04 - Controller nâng cao: Account/Profile + Route (ASP.NET Core MVC)

**Bài làm theo đúng source hướng dẫn của thầy:** https://github.com/tvchung/k24cnt1_netcore.git (project `lab04`)

## 📋 Thông tin sinh viên

| Thông tin | Chi tiết |
|-----------|----------|
| **Mã sinh viên** | 2410900035 |
| **Họ và tên** | Nguyễn Văn Hiệp |
| **Lớp** | K24CNT1 |
| **Học phần** | Phát triển ứng dụng với công nghệ .NET |

## 📖 Nội dung bài (theo lab guide)

| # | Bước | Nội dung | File | URL test |
|---|------|----------|------|----------|
| 1 | Bước 5 | View hiển thị danh sách account (avatar + tên + bio + nút Profile) | `Views/Account/Index.cshtml` | `/Account/Index` |
| 2 | Bước 6 | Model `Account`: Id, Name, Email, Phone, Avatar, Address, Bio, Gender, Birthday | `Models/Account.cs` | — |
| 3 | Bước 7 | Action `Profile` — chi tiết 1 account | `Controllers/AccountController.cs` | `/Account/Profile/{id}` |
| 4 | Bước 8 | View Profile: FullName, Email, Phone, Address, Bio, Gender, Birthday | `Views/Account/Profile.cshtml` | `/Account/Profile/1` |
| 5 | Bước 10 | Route riêng cho AccountController | `Program.cs` | — |
| 6 | Bước 11 | Menu Account dùng `asp-route="account"` | `Views/Shared/_Layout.cshtml` | — |
| 7 | Bước 12 | Route đặt tên `ho-so-cua-toi` cho action Profile | `Controllers/AccountController.cs` | `/ho-so-cua-toi/2` |
| 8 | Bước 15 | Profile nhận tham số `id` + LINQ `FirstOrDefault` | `Controllers/AccountController.cs` | `/Account/Profile/3` |

> 💡 **Dữ liệu:** account 1 là **Nguyễn Văn Hiệp — MSSV 2410900035** (SĐT 0988089376, SN 27/09/2006); account 2, 3 giữ mock data theo source thầy.

## Cách chạy

### Cách 1 — Visual Studio
1. Mở file `lab04.sln`
2. F5 — trình duyệt tự mở

### Cách 2 — Command line
```bash
cd lab04
dotnet restore
dotnet run
```
Mở trình duyệt: `http://localhost:5011`

## Cấu trúc thư mục
```
lab04/
├── Controllers/
│   ├── HomeController.cs
│   └── AccountController.cs   ← Index + Profile (LINQ)
├── Models/
│   ├── Account.cs             ← 9 thuộc tính
│   └── ErrorViewModel.cs
├── Views/
│   ├── Account/Index.cshtml, Profile.cshtml
│   ├── Home/Index.cshtml, Privacy.cshtml
│   └── Shared/_Layout.cshtml
├── wwwroot/
│   ├── Avatar/02.png, 03.png, 04.png
│   └── lib/ (bootstrap, jquery)
├── Program.cs                 ← 2 route: default + account
└── lab04.csproj  (.NET 8)
```

## Ghi chú
- Code giữ nguyên theo lab guide của thầy (Devmaster)
- Chạy đúng trên .NET 8 SDK
