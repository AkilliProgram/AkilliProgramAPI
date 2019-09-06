using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkilliProgramApi.Model
{
    public class NetDbContext : IdentityDbContext<IdentityUser>
    {

         public  NetDbContext( DbContextOptions<NetDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new {Id =1, Name="Admin", NormalizedName="ADMIN"}
                );
        }
    }
}
