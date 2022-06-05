

namespace CourseWork
{
    public class Car_information
    {
        public class Car
        {
            public string brand { get; set; }
            public int release_year { get; set; }
            public int price { get; set; }
            public Overall_Characteristics characteristics { get; set; }
            
            public string peculiarities { get; set; }
            public string condition { get; set; }


            public Car(string brand = "", int release_year = -1, int price = -1, int cylinder_amount = -1, int engine_volume = -1, int horse_power = -1,
                string transmission_type = "", int length = -1, int width = -1, int height = -1, string peculiarities = "",
                string condition = "")
            {
                this.brand = brand;
                this.release_year = release_year;
                Engine engine = new Engine(cylinder_amount, engine_volume, horse_power);
                Dimensions dimensions = new Dimensions(length, width, height);
                characteristics = new Overall_Characteristics(engine, transmission_type, dimensions);
                this.peculiarities = peculiarities;
                this.condition = condition;
                this.price = price;
            }

        }

        public class Overall_Characteristics
        {
            public Engine engine;
            public string transmission_type;
            public Dimensions dimensions;

            public Overall_Characteristics(Engine engine, string transmission_type, 
                Dimensions dimensions)
            {
                this.engine = engine;
                this.transmission_type = transmission_type;
                    this.dimensions = dimensions;
            }

        }
        
        public class Engine
        {
            public int cylinder_amount;
            public int volume;
            public int horse_power;

            public Engine(int cylinder_amount = -1, int volume = -1, int horse_power = -1)
            {
                this.cylinder_amount = cylinder_amount;
                this.volume = volume;
                this.horse_power = horse_power;
            }
        }
        
        public class Dimensions
        {
            public int length;
            public int width;
            public int height;

            public Dimensions(int length = -1, int width = -1, int height = -1)
            {
                this.length = length;
                this.width = width;
                this.height = height;
            }
        }

    }
}
