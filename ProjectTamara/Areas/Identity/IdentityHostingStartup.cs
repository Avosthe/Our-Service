﻿using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectTamara.Models;

[assembly: HostingStartup(typeof(ProjectTamara.Areas.Identity.IdentityHostingStartup))]
namespace ProjectTamara.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ProjectTamaraContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ProjectTamaraContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<ProjectTamaraContext>();
            });
        }
    }
}