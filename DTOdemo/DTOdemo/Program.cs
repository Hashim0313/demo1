using DTOdemo.Models;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AutoMapper;
using DTOdemo.DTO;
using DTOdemo.Models;
using Microsoft.EntityFrameworkCore;
using DTOdemo.Service;
using DTOdemo.Helper;
using Microsoft.Extensions.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();


builder.Services.AddDbContext<DTODemoDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));



builder.Services.AddScoped<JobService>();



builder.Services.AddAutoMapper(typeof(AutoMapperProfile));







var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
