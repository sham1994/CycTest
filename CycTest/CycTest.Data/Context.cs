using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CycTest.Entities.Entities;

namespace CycTest.Data
{
   public  class Context : DbContext
    {

        public Context() : base("name = SampleConnectionString")
        {
            

        }

        public DbSet<Stock_Book> MainCatagory { get; set; }
        public DbSet<Stock_Cat> SubCatagory { get; set; }

    }
}
