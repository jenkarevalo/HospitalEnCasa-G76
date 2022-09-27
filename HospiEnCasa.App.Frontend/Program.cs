using HospiEnCasa.App.Persistencia;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using HospiEnCasa.App.Frontend.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("IdentityDataContextConnection") ?? throw new InvalidOperationException("Connection string 'IdentityDataContextConnection' not found.");

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<HospiEnCasa.App.Persistencia.AppContext>();
builder.Services.AddDbContext<IdentityDataContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<IdentityDataContext>();
builder.Services.AddTransient<IRepositorioMedico, RepositorioMedico>();
builder.Services.AddTransient<IRepositorioPaciente, RepositorioPaciente>();
builder.Services.AddTransient<IRepositorioFamiliarDesignado, RepositorioFamiliarDesignado>();
builder.Services.AddTransient<IRepositorioUsuario, RepositorioUsuario>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();

app.Run();