using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC5Final.Models
{
    public class MVC5FinalContext : DbContext
    {
        public MVC5FinalContext() : base("name=DefaultConnection") { }
       
        
        public DbSet<SystemLog> SystemLog { get; set; }
        public DbSet<GuestTable> GuestTable { get; set; }
    }
}