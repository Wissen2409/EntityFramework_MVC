using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// veri tabanı ayarlarını yapalım!!
builder.Services.AddDbContext<BooksDbContext>(option=>
option.UseSqlServer("Server=localhost; Database=BookStore; User Id=sa; Password=reallyStrongPwd123; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True;"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


// Microsoft.EntityFrameworkCore

// Microsoft.EntityFrameworkCore.SqlServer

// Microsoft.EntityFrameworkCore.Tools