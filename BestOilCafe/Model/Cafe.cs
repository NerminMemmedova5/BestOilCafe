using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOilCafe.Model
{
    public class Cafe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Pieces { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
