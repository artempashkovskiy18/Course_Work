using System.Collections.Generic;

namespace CourseWork.Repositories
{
    public interface ICarRepository
    {
        void SaveAllCars(List<Car> cars);

        List<Car> GetAllCars();

        void SaveCar(Car car);

        void DeleteCar(Car car);
        
        void EditCar(Car car);
    }
}