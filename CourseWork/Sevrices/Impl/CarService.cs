using System.Collections.Generic;
using System.IO;
using CourseWork.Repositories.Impl;
using CourseWork.Sevrices;

namespace CourseWork
{
    public class CarService : ICarService
    {
        private CarRepository repository = new CarRepository();
        public void PutAllCarsInFile(List<Car> cars)
        {
            if (!File.Exists(FilePath.cars_File_Path))
            {
                File.Create(FilePath.cars_File_Path);
            }
            repository.PutAllCarsInFile(cars,FilePath.cars_File_Path);
        }

        public List<Car> GetALlCarsFromFile()
        {
            if (!File.Exists(FilePath.cars_File_Path))
            {
                File.Create(FilePath.cars_File_Path);
            }
            return repository.GetALlCarsFromFile(FilePath.cars_File_Path);
        }

        public void PutOneCarInFile(Car car)
        {
            if (!File.Exists(FilePath.cars_File_Path))
            {
                File.Create(FilePath.cars_File_Path);
            }
            repository.PutOneCarInFile(car, FilePath.cars_File_Path);
        }
    }
}