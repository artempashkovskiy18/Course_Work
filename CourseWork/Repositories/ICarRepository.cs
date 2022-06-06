using System.Collections.Generic;

namespace CourseWork.Repositories
{
    public interface ICarRepository
    {
        void PutAllCarsInFile(List<Car> cars, string path);

        List<Car> GetALlCarsFromFile(string path);

        void PutOneCarInFile(Car car, string path);
    }
}