using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Product_Choices.Models
{
    public class Product_ChoicesContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Product_ChoicesContext() : base("name=Product_ChoicesContext")
        {
        }

        public System.Data.Entity.DbSet<Product_Choices.Models.Trial> Trials { get; set; }

        public System.Data.Entity.DbSet<Product_Choices.Models.Questions1> Questions1 { get; set; }

        public System.Data.Entity.DbSet<Product_Choices.Models.Questions2> Questions2 { get; set; }
    }
}
