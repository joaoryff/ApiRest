﻿using Microsoft.EntityFrameworkCore;

namespace RestWithASPNETUdemy.Model.Context
{
    public class MySQLContext : DbContext
    {
        protected MySQLContext()
        {
        }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Book> Book { get; set; }

    }
}
