using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static CourseWork.CarsFileIndexes;

namespace CourseWork.Repositories.Impl
{
    public class CarRepository : ICarRepository
    {
        public void SaveAllCars(List<Car> cars)
        {
            if (!File.Exists(FilePath.cars_File_Path))
            {
                File.Create(FilePath.cars_File_Path);
            }

            using (StreamWriter writer = new StreamWriter(FilePath.cars_File_Path))
            {
                foreach (Car car in cars)
                {
                    string carString = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}",
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
                        car.peculiarities,
                        car.condition,
                        car.id);

                    writer.WriteLine(carString);
                }
            }
        }
        public List<Car> GetAllCars()
        {
            if (!File.Exists(FilePath.cars_File_Path))
            {
                File.Create(FilePath.cars_File_Path);
            }

            List<Car> cars = new List<Car>();
            foreach (string line in File.ReadLines(FilePath.cars_File_Path))
            {
                List<string> carInfo = line.Split(',').ToList();
                Car car = new Car(Guid.Parse(carInfo[car_id_index]),
                    carInfo[brand_index],
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

                cars.Add(car);
            }

            return cars;
        }
        public void SaveCar(Car car)
        {
            if (!File.Exists(FilePath.cars_File_Path))
            {
                File.Create(FilePath.cars_File_Path);
            }

            using (StreamWriter writer = new StreamWriter(FilePath.cars_File_Path, true))
            {
                string carString = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}",
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
                    car.peculiarities,
                    car.condition,
                    car.id);

                writer.WriteLine(carString);
            }
        }
        public void DeleteCar(Car car)
        {
            List<string> lines = File.ReadAllLines(FilePath.cars_File_Path).ToList();

            using (StreamWriter writer = new StreamWriter(FilePath.cars_File_Path))
            {
                foreach (string line in lines.Where(line => !line.Contains(car.id.ToString())))
                {
                    writer.WriteLine(line);
                }
            }
        }
        
        public void EditCar(Car car)
        {
            DeleteCar(car);
            SaveCar(car);
        }
    }
}