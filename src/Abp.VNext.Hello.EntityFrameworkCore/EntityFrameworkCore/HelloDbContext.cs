﻿using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.VNext.Hello.EntityFrameworkCore
{

    [ConnectionStringName("Awesome")]
    public class HelloDbContext : AbpDbContext<HelloDbContext>
    {

        public DbSet<City> Cities { get; set; }

        public DbSet<EztvItem> Eztvs { get; set; }

        public DbSet<Country> Countries { get; set; }
        public DbSet<StateProvince> StateProvinces { get; set; }
        public DbSet<Scheduler> Schedulers { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public HelloDbContext(DbContextOptions<HelloDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureHello();
        }
    }
}
