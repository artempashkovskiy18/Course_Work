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
                repository.SaveCar(car);
            }
            //repository.PutAllCarsInFile(cars);
        }
        public List<Car> GetCars()
        {
            return repository.GetAllCars();
        }
        public void SaveCar(Car car)
        {
            repository.SaveCar(car);
        }
        public void DeleteCar(Car car)
        {
            repository.DeleteCar(car);
        }
        public void EditCar(Car car)
        {
            repository.EditCar(car);
        }
    }
}