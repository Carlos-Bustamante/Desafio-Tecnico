using System;
using System.Collections.Generic;
using Desafio_Tecnico.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Desafio_Tecnico.Models;

public partial class TestContext : DbContext
{
    public TestContext()
    {
    }

    public TestContext(DbContextOptions<TestContext> options)
        : base(options)
    {
    }

    public DbSet<TipoProducto> TipoProductos { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<Stock> Stocks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
                //IConfigurationRoot configuration = new ConfigurationBuilder()
                //        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                //        .AddJsonFile("Server=DESKTOP-VEEMG5N\\SQLEXPRESS;Database=Test;Encrypt=False;TrustServerCertificate=True;Trusted_Connection=True")
                //        .Build();
                optionsBuilder.UseSqlServer("Server=DESKTOP-VEEMG5N\\SQLEXPRESS;Database=Test;Encrypt=False;TrustServerCertificate=True;Trusted_Connection=True");
        }
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
