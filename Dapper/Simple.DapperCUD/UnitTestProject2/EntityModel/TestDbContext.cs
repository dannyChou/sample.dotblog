﻿using System.Data.Entity;

namespace UnitTestProject2.EntityModel
{
    internal class TestDbContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
    }
}