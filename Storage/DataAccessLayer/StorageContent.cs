using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Storage.DataAccessLayer
{
    public class StorageContent : DbContext
    {
        public StorageContent() : base("DefaultConnection") { }
        public DbSet<Models.Product> Products { get; set; }
    }
}