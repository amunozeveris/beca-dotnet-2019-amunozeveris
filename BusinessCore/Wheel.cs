using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCore
{
    public class Wheel
    {
        public string Brand { get; set; }
        public float Inches { get; set; }

        public Wheel(string brand, float inches)
        {
            this.Brand = brand;
            this.Inches = inches;
        }
    }
}
