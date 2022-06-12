using System.Collections.Generic;

namespace CourseWork.Sevrices
{
    public interface ICarService
    {
        void SaveCars(List<Car> cars);

        List<Car> GetCars();

        void SaveCar(Car car);

        void DeleteCar(Car car);

        void EditCar(Car car);
    }
}