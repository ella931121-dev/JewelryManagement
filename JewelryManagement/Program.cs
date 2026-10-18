
using Microsoft.EntityFrameworkCore;
using JewelryManagement.Data;

var builder = WebApplication.CreateBuilder(args);

// 加入 MVC 服務
builder.Services.AddControllersWithViews();

// 設定 SQLite 資料庫連線
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

var app = builder.Build();

// 設定 HTTP 請求處理流程
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

// .NET 10 靜態資源設定
app.MapStaticAssets();

// 設定 MVC 預設路由
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
