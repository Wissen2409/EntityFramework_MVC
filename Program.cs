using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// veri tabanı ayarlarını yapalım!!
builder.Services.AddDbContext<BooksDbContext>(option=>
option.UseSqlServer("Server=db4856.public.databaseasp.net; Database=BookStore; User Id=db4856; Password=Ni4!7@wA-E2r; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True;"));


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
