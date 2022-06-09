using System;

namespace CourseWork
{
    public class Car
    {

        public Guid id;

        public string brand { get; set; }
        public int releaseYear { get; set; }
        public int price { get; set; }
        public OverallCharacteristics characteristics { get; set; }
        public string peculiarities { get; set; }
        public string condition { get; set; }


        public Car(Guid id, string brand = "", int releaseYear = -1, int price = -1, int cylinderAmount = -1, int engineVolume = -1, int horsePower = -1,
            string transmissionType = "", int length = -1, int width = -1, int height = -1, string peculiarities = "",
            string condition = "")
        {
            this.id = id;
            
            this.brand = brand;
            this.releaseYear = releaseYear;
            Engine engine = new Engine(cylinderAmount, engineVolume, horsePower);
            Dimensions dimensions = new Dimensions(length, width, height);
            characteristics = new OverallCharacteristics(engine, transmissionType, dimensions);
            this.peculiarities = peculiarities;
            this.condition = condition;
            this.price = price;
        }
        
        public Car(string brand = "", int releaseYear = -1, int price = -1, int cylinderAmount = -1, int engineVolume = -1, int horsePower = -1,
            string transmissionType = "", int length = -1, int width = -1, int height = -1, string peculiarities = "",
            string condition = "")
        {
            id = Guid.NewGuid();
            
            this.brand = brand;
            this.releaseYear = releaseYear;
            Engine engine = new Engine(cylinderAmount, engineVolume, horsePower);
            Dimensions dimensions = new Dimensions(length, width, height);
            characteristics = new OverallCharacteristics(engine, transmissionType, dimensions);
            this.peculiarities = peculiarities;
            this.condition = condition;
            this.price = price;
        }

    }
}