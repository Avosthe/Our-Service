﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectTamara.Data;

namespace ProjectTamara.Models
{
    public class ProjectTamaraContext : IdentityDbContext<IdentityUser>
    {
        public ProjectTamaraContext(DbContextOptions<ProjectTamaraContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<Beneficiary> Beneficiary { get; set; }
        public DbSet<BeneficiaryCodes> BeneficiaryCodes { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<BaseUser> BaseUser { get; set; }

        public DbSet<GeneralUser> GeneralUser { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<VoteLog> VoteLog { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}
