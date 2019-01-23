using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCore
{
    public class Chassis
    {
        public string Brand { get; set; }

        public Chassis(string brand)
        {
            this.Brand = brand;
        }
    }
}
