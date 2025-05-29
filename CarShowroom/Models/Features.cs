using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom.Models
{
    /// <summary> Car techincal features class</summary>
    public class Features
    {
        /// <summary> Engine type of the car</summary>
        public string Engine { get; set; }

        /// <summary> Horsepower of the car</summary>
        public int HorsePowers { get; set; }

        /// <summary> Fuel type of the car</summary>
        public string FuelType { get;set; }

        /// <summary> Default constructor of Features class</summary>
        public Features (string engine, int horsePowers, string fuelType)
        {
            Engine = engine;
            HorsePowers = horsePowers;
            FuelType = fuelType;
        }

        /// <summary> Override ToString method to provide a string representation of the features</summary>
        public override string ToString()
        {
            return $"{Engine},{HorsePowers} HP,{FuelType}";
        }
    }
}
