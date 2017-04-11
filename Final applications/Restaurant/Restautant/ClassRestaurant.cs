using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class ClassRestaurant
    {
        public string Name { get; set; }

        public ClassRestaurant(string stallname)
        {
            this.Name = stallname;
        }

        public override string ToString()
        {
            return "STALL NAME: " + this.Name;
        }
    }
}
