using System.Collections.Generic;

namespace CourseWork.Sevrices
{
    public interface ICarService
    {
        void PutAllCarsInFile(List<Car> cars);

        List<Car> GetALlCarsFromFile();

        void PutOneCarInFile(Car car);
    }
}