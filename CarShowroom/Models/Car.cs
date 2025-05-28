using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom.Models
{
    /// <summary>
    /// Class representing a car with various properties and features.
    /// </summary>
    public class Car
    {
        /// <summary> Brand of the car.</summary>
        public string Brand { get; set; } = "Unknown Brand";

        /// <summary> Model of the car.</summary>
        public string Model { get; set; } = "Unknown Model";

        /// <summary> Country of origin of the car.</summary>
        public string OriginCountry { get; set; } = "Unknown Country";

        /// <summary> Year of release of the car.</summary>
        public int ReleaseYear { get; set; } = 0;

        /// <summary> Features of the car, encapsulated in a Features object.</summary>
        public Features Features { get; set; } = new Features("Default Engine", 0, "Unknown Fuel");

        /// <summary> Price of the car.</summary>
        public int Price { get; set; } = 0;

        /// <summary> Enumeration representing the condition of the car.</summary>
        public enum CarCondition
        {
            New,
            Used
        }
        /// <summary> Condition of the car. </summary>
        public CarCondition Condition { get; set; } = CarCondition.Used;

        /// <summary> Default constructor. </summary>
        public Car() { }

        /// <summary> Constructor to initialize a car with specific properties.</summary>
        public Car(string brand, string model, string originCountry, int releaseYear, Features features, int price, CarCondition condition)
        {
            Brand = brand;
            Model = model;
            OriginCountry = originCountry;
            ReleaseYear = releaseYear;
            Features = features;
            Price = price;
            Condition = condition;
        }

        /// <summary> Override ToString method to provide a string representation of the car.</summary>
        public override string ToString()
        {
            return $"{Brand} {Model} ({ReleaseYear}) from {OriginCountry}\n Features: {Features}\n Price: ${Price:N0}\n";
        }
        /// <summary> Method to get a display string for the car, suitable for UI elements. </summary>
        public string DisplayString()
        {
            return $"{Brand} {Model} ({ReleaseYear})";
        }
    }

}
