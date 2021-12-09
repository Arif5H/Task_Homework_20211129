using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az
{
    internal class Car
    {
        public string Model;
        public string Brand;
        public int Year;
        public string Location;
        public double Price;
        
        public string GetCarInfo()
        {
            return $"{Model}. {Brand}, {Year}, {Location}, {Price}";
        }


    }
}
