﻿using System;
using Microsoft.EntityFrameworkCore;
using TrialWebApp.DataBase;
//using Microsoft.Extensions.Logging;


namespace TrialWebApp.DataBase
{
    public class ApplicationConnectionDb : DbContext
    {
        public DbSet<Category> kategoriler { get; set; }
        public DbSet<User> kullanicilar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseMySql("server=database-1.cgoekeddamxk.eu-north-1.rds.amazonaws.com;port=3306;user=admin;password=2!5abA%9TqL*R&7;database=YemekTarifi", new MySqlServerVersion(new Version(8, 0, 32)))
                .UseLoggerFactory(LoggerFactory.Create(b => b
                .AddConsole()
                .AddFilter(level => level >= LogLevel.Information)))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }
    }
}
