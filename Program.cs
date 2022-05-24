using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Notebook_VS_Final_assignment.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ContextNotebookConnection") ?? throw new InvalidOperationException("Connection string 'ContextNotebookConnection' not found.");

builder.Services.AddDbContext<ContextNotebook>(options =>
    options.UseSqlServer(connectionString));;

builder.Services.AddDefaultIdentity<Notebook_User>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ContextNotebook>();;

// Add services to the container.
builder.Services.AddRazorPages();

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
