using SistemaDeCadenasAlimenticias.Data.EF;
using SistemaDeCadenasAlimenticias.Servicios;
using SistemaDeCadenasAlimenticias.Web.CadenaApiCliente;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<Pw320231cModelo2doParcialContext>();
builder.Services.AddScoped<ICadenasServicio, CadenasServicio>();
builder.Services.AddScoped<ISucursalesServicio, SucursalesServicio>();
//Configuracion APICliente
builder.Services.AddScoped<ICadenaApiCliente, CadenaApiCliente>();
builder.Services.AddHttpClient("CadenasAlimenticiasApiCliente",cliente=>
cliente.BaseAddress=new Uri("https://localhost:7116"));
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
