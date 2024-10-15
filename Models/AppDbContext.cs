﻿using Microsoft.EntityFrameworkCore;


namespace IletisimForm.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) 
        {
        
        }

        public DbSet<User> Users { get; set; }
        
    }
}
