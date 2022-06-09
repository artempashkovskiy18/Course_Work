using System.Collections.Generic;
using CourseWork.Repositories;
using CourseWork.Repositories.Impl;
using CourseWork.Sevrices;
using static CourseWork.CarsFileIndexes;

namespace CourseWork
{
    public class CarService : ICarService
    {
        private ICarRepository repository = new CarRepository();
        
        public void SaveCars(List<Car> cars)
        {
            foreach (Car car in cars)
            {
                repository.PutCarInFile(car);
            }
            //repository.PutAllCarsInFile(cars);
        }
        public List<Car> GetCars()
        {
            return repository.GetAllCarsFromFile();
        }
        public void SaveCar(Car car)
        {
            repository.PutCarInFile(car);
        }
        public void DeleteCar(Car car)
        {
            repository.DeleteCar(car);
        }
        public Car EditCar(Car car, int indexToEdit, string newValue)
        {
            switch (indexToEdit)
            {
                case peculiarities_index:
                    DeleteCar(car);
                    car.peculiarities = newValue;
                    SaveCar(car);
                    break;
                case condition_index:
                    DeleteCar(car);
                    car.condition = newValue;
                    SaveCar(car);
                    break;
                case price_index:
                    DeleteCar(car);
                    car.price = int.Parse(newValue);
                    SaveCar(car);
                    break;
            }

            return car;
        }
    }
}