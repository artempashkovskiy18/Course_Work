using System.Collections.Generic;
using System.IO;
using CourseWork.Repositories.Impl;
using CourseWork.Sevrices;

namespace CourseWork
{
    public class CustomerService : ICustomerService
    {
        private CustomerRepository repository = new CustomerRepository();
        
        private bool IsCarSuitable(Car car, Customer customer)
        {
            if (car.price <= customer.finances)
            {
                return car.brand == customer.requiredCar.brand && customer.requiredCar.brand != "" ||
                       car.releaseYear == customer.requiredCar.releaseYear && customer.requiredCar.releaseYear != -1 ||
                       car.characteristics.engine.cylinderAmount == customer.requiredCar.characteristics.engine.cylinderAmount && customer.requiredCar.characteristics.engine.cylinderAmount != -1 ||
                       car.characteristics.engine.volume == customer.requiredCar.characteristics.engine.volume && customer.requiredCar.characteristics.engine.volume != -1 ||
                       car.characteristics.engine.horsePower == customer.requiredCar.characteristics.engine.horsePower && customer.requiredCar.characteristics.engine.horsePower != -1 ||
                       car.characteristics.transmissionType == customer.requiredCar.characteristics.transmissionType && customer.requiredCar.characteristics.transmissionType != "" ||
                       car.characteristics.dimensions.length == customer.requiredCar.characteristics.dimensions.length && customer.requiredCar.characteristics.dimensions.length != -1 ||
                       car.characteristics.dimensions.width == customer.requiredCar.characteristics.dimensions.width && customer.requiredCar.characteristics.dimensions.width != -1 ||
                       car.characteristics.dimensions.height == customer.requiredCar.characteristics.dimensions.height && customer.requiredCar.characteristics.dimensions.height != -1 ||
                       car.condition == customer.requiredCar.condition && customer.requiredCar.condition != "";
            }

            return false;

        }
        
        public List<Car> GetSuitableCars(List<Car> cars, Customer customer)
        {
            List<Car> suitableCars = new List<Car>();
            
            foreach (Car car in cars)
            {
                if (IsCarSuitable(car, customer))
                {
                    suitableCars.Add(car);
                }
            }

            return suitableCars;
        }

        public void PutAllCustomersInFile(List<Customer> customers)
        {
            if (!File.Exists(FilePath.customers_File_Path))
            {
                File.Create(FilePath.customers_File_Path);
            }
            repository.PutAllCustomersInFile(customers, FilePath.customers_File_Path);
        }

        public List<Customer> GetALlCustomersFromFile()
        {
            if (!File.Exists(FilePath.customers_File_Path))
            {
                File.Create(FilePath.customers_File_Path);
            }
            return repository.GetALlCustomersFromFile(FilePath.customers_File_Path);
        }

        public void PutOneCustomerInFile(Customer customer)
        {
            if (!File.Exists(FilePath.customers_File_Path))
            {
                File.Create(FilePath.customers_File_Path);
            }
            repository.PutOneCustomerInFile(customer, FilePath.customers_File_Path);
        }
    }
}