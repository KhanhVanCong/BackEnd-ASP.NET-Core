using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Practive_shop.Models;

[assembly: HostingStartup(typeof(Practive_shop.Areas.Identity.IdentityHostingStartup))]
namespace Practive_shop.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDefaultIdentity<IdentityUser>()
                        .AddEntityFrameworkStores<AppDbContext>();
            });
        }
    }
}