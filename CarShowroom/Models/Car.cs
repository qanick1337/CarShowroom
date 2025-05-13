using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom.Models
{
    public class Car
    {
        public string Brand { get; set; } = "Unknown Brand";
        public string Model { get; set; } = "Unknown Model";
        public string OriginCountry { get; set; } = "Unknown Country";
        public int ReleaseYear { get; set; } = 0;
        public Features Features { get; set; } = new Features("Default Engine", 0, "Unknown Fuel");
        public double Price { get; set; } = 0.0;

        private string condition = "used";
        public string Condition
        {
            get => condition ;
            set
            {
                if (value == "new" || value == "used")
                {
                    condition = value;
                }
                    
            }
        }



        public Car() { }
        public Car(string brand, string model, string originCountry, int releaseYear, Features features, double price, string condition)
        {
            Brand = brand;
            Model = model;
            OriginCountry = originCountry;
            ReleaseYear = releaseYear;
            Features = features;
            Price = price;
            Condition = condition;
        }

        public override string ToString()
        {
            return $"{Brand} {Model} ({ReleaseYear}) from {OriginCountry}\n Features: {Features}\n Price: ${Price:N0}\n";
        }
    }

}
