﻿using Microsoft.AspNetCore.DataProtection.KeyManagement;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllers();

app.UseEndpoints(endpoints =>
    {
    endpoints.Map("/", async context =>
    {
        await context.Response.WriteAsync(app.Configuration["MyKey"]+ "\n");
        await context.Response.WriteAsync(app.Configuration.GetValue<string>("hello", "hi"));
    });   
});

app.Run();

