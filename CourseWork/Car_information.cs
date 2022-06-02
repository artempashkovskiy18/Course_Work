

namespace CourseWork
{
    class Car_information
    {
        public class Car
        {
            public string brand;
            public int release_year;
            public int price;
            public Overall_characteristics characteristics;
            public string peculiarities;
            public string condition;


            public Car(string brand = "", int release_year = -1, int price = -1, int cylinder_amount = -1, int engine_volume = -1, int horse_power = -1,
                string transmission_type = "", int length = -1, int width = -1, int height = -1, string peculiarities = "",
                string condition = "")
            {
                this.brand = brand;
                this.release_year = release_year;
                characteristics = new Overall_characteristics(cylinder_amount, engine_volume, horse_power,
                transmission_type, length, width, height);
                this.peculiarities = peculiarities;
                this.condition = condition;
                this.price = price;
            }

        }

        public class Overall_characteristics
        {
            public Engine_characteristics engine;
            public Transmission_characteristics transmission;
            public Dimensions_characteristics dimensions;

            public Overall_characteristics(int cylinder_amount = -1, int engine_volume = -1, int horse_power = -1,
                string transmission_type = "", int length = -1, int width = -1, int height = -1)
            {
                engine = new Engine_characteristics(cylinder_amount, engine_volume, horse_power);
                transmission = new Transmission_characteristics(transmission_type);
                dimensions = new Dimensions_characteristics(length, width, height);
            }

        }
        
        public class Engine_characteristics
        {
            public int cylinder_amount;
            public int volume;
            public int horse_power;

            public Engine_characteristics(int cylinder_amount = -1, int volume = -1, int horse_power = -1)
            {
                this.cylinder_amount = cylinder_amount;
                this.volume = volume;
                this.horse_power = horse_power;
            }
        }
        
        public class Transmission_characteristics
        {
            public string transmission_type;

            public Transmission_characteristics(string transmission_type = "")
            {
                this.transmission_type = transmission_type;
            }
        }
        
        public class Dimensions_characteristics
        {
            public int length;
            public int width;
            public int height;

            public Dimensions_characteristics(int length = -1, int width = -1, int height = -1)
            {
                this.length = length;
                this.width = width;
                this.height = height;
            }
        }

    }
}
