using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_server_crud.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace blazor_server_crud.Data
{
    public class BlazorDemoContext : DbContext
    {
        public BlazorDemoContext(DbContextOptions<BlazorDemoContext> options) : base(options)
        {

        }
        public DbSet<Gadgets> Gadgets { get; set; }
    }
}
