﻿using System.Data.Entity;
using System.Linq;

namespace Receiver161
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DefaultConnection"){}

        public DbSet<Message> Messages { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Binary> Binaries { get; set; } 
        public DbSet<Messages_Content> Messages_Contents { get; set; }
        public DbSet<Contents_Binary> Contents_Binaries { get; set; }

    }
}
