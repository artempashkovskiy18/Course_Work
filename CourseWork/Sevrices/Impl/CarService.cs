using System.Collections.Generic;
using CourseWork.Repositories.Impl;
using CourseWork.Sevrices;

namespace CourseWork
{
    public class CarService : ICarService
    {
        private CarRepository repository = new CarRepository();
        public void PutAllCarsInFile(List<Car> cars)
        {
            repository.PutAllCarsInFile(cars,FilePath.cars_File_Path);
        }

        public List<Car> GetALlCarsFromFile()
        {
            return repository.GetALlCarsFromFile(FilePath.cars_File_Path);
        }

        public void PutOneCarInFile(Car car)
        {
            repository.PutOneCarInFile(car, FilePath.cars_File_Path);
        }
    }
}