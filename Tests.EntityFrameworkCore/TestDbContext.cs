using Microsoft.EntityFrameworkCore;
using Sheleski.Roobug.Geo.EntityFrameworkCore;
using Sheleski.Roobug.Scorm;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.EntityFrameworkCore
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions options): base(options)
        {

        }

        public TestDbContext() : base()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

//            modelBuilder.UseScorm();
            modelBuilder.UseGeo();

            base.OnModelCreating(modelBuilder);
        }
    }
}
