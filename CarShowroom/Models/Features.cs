using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom.Models
{
    public class Features
    {
        public string Engine { get; set; }
        public int HorsePowers { get; set; }
        public string FuelType { get;set; }

        public Features (string engine, int horsePowers, string fuelType)
        {
            Engine = engine;
            HorsePowers = horsePowers;
            FuelType = fuelType;
        }

        public override string ToString()
        {
            return $"Engine - {Engine}, Horsepowers - {HorsePowers}, FuelType - {FuelType}";
        }
    }
}
