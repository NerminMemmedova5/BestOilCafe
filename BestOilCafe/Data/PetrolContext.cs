using BestOilCafe.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOilCafe.Data
{
    public class PetrolContext:DbContext
    {
        public PetrolContext():base("PetrolDb")
        {

        }
        public DbSet<Petrol> Petrols { get; set; }
        public DbSet<Check> Checks { get; set; }
        public DbSet<Cafe> Cafes { get; set; }

    }
}
