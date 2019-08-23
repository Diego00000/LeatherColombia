using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LeatherColombia.Models;

namespace LeatherColombia.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<LeatherColombia.Models.Producto> Producto { get; set; }
        public DbSet<LeatherColombia.Models.MetodoPago> MetodoPago { get; set; }
        public DbSet<LeatherColombia.Models.Pais> Pais { get; set; }
        public DbSet<LeatherColombia.Models.Ciudad> Ciudad { get; set; }
        public DbSet<LeatherColombia.Models.Cliente> Cliente { get; set; }
        public DbSet<LeatherColombia.Models.Pedido> Pedido { get; set; }
        public DbSet<LeatherColombia.Models.DetallePedido> DetallePedido { get; set; }
    }
}
