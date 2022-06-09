using System.Collections.Generic;

namespace CourseWork.Repositories
{
    public interface ICarRepository
    {
        void PutAllCarsInFile(List<Car> cars);

        List<Car> GetAllCarsFromFile();

        void PutCarInFile(Car car);

        void DeleteCar(Car car);
    }
}