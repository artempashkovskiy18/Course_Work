using System.Collections.Generic;
using System.IO;
using System.Linq;
using static CourseWork.CarsFileIndexes;

namespace CourseWork.Repositories.Impl
{
    public class CarRepository : ICarRepository
    {
        public void PutAllCarsInFile(List<Car> cars, string path)
        {
            using (StreamWriter w = new StreamWriter(path))
            {
                foreach (Car car in cars)
                {
                    string temp = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}",
                        car.brand, 
                        car.releaseYear,
                        car.price,
                        car.characteristics.engine.cylinderAmount,
                        car.characteristics.engine.volume, 
                        car.characteristics.engine.horsePower,
                        car.characteristics.transmissionType,
                        car.characteristics.dimensions.length,
                        car.characteristics.dimensions.width,
                        car.characteristics.dimensions.height,
                        car.peculiarities, car.condition);
        
                    w.WriteLine(temp);
                }
            }
        }

        public List<Car> GetALlCarsFromFile(string path)
        {
            List<Car> cars = new List<Car>();
            foreach (string line in File.ReadLines(path))
            {
                List<string> carInfo = line.Split(',').ToList();
                Car temp = new Car(carInfo[brand_index],
                    int.Parse(carInfo[release_year_index]),
                    int.Parse(carInfo[price_index]),
                    int.Parse(carInfo[cylinder_amount_index]),
                    int.Parse(carInfo[volume_index]),
                    int.Parse(carInfo[horse_power_index]),
                    carInfo[transmission_type_index],
                    int.Parse(carInfo[length_index]),
                    int.Parse(carInfo[width_index]),
                    int.Parse(carInfo[height_index]),
                    carInfo[peculiarities_index],
                    carInfo[condition_index]);

                cars.Add(temp);
            }

            return cars;
        }

        public void PutOneCarInFile(Car car, string path)
        {
            using (StreamWriter w = new StreamWriter(path, true))
            {
                string temp = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}",
                    car.brand, 
                    car.releaseYear,
                    car.price,
                    car.characteristics.engine.cylinderAmount,
                    car.characteristics.engine.volume, 
                    car.characteristics.engine.horsePower,
                    car.characteristics.transmissionType,
                    car.characteristics.dimensions.length,
                    car.characteristics.dimensions.width,
                    car.characteristics.dimensions.height,
                    car.peculiarities, car.condition);
                
                w.WriteLine(temp);
            }
        }
    }
}