﻿using Estudo_1___Web_API.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Estudo_1___Web_API.Infrastructure
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(
                "Server=localhost;"+
                "Port=5432;Database=employee_sample;" +
                "User Id=postgres;"+
                "Password=123;");
    }
}
