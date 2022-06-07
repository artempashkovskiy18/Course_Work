using System.Collections.Generic;
using System.IO;
using CourseWork.Repositories.Impl;
using CourseWork.Sevrices;

namespace CourseWork
{
    public class CustomerService : ICustomerService
    {
        private CustomerRepository repository = new CustomerRepository();
        public List<Car> GetSuitableCars(List<Car> cars, Customer customer)
        {
            List<Car> suitableCars = new List<Car>();
            
            foreach (Car element in cars) //find suitable cars by price
            {
                if (element.price <= customer.finances)
                {
                    suitableCars.Add(element);
                }
            }
            
            
            for(int i = 0; i < suitableCars.Count; i++) //delete cars we don't need by other characteristics
            {
                if (suitableCars[i].brand != customer.requiredCar.brand && 
                    customer.requiredCar.brand != "")
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].releaseYear != customer.requiredCar.releaseYear && 
                    customer.requiredCar.releaseYear != -1)
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].characteristics.engine.cylinderAmount != customer.requiredCar.characteristics.engine.cylinderAmount && 
                    customer.requiredCar.characteristics.engine.cylinderAmount != -1)
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].characteristics.engine.volume != customer.requiredCar.characteristics.engine.volume && 
                    customer.requiredCar.characteristics.engine.volume != -1)
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].characteristics.engine.horsePower != customer.requiredCar.characteristics.engine.horsePower && 
                    customer.requiredCar.characteristics.engine.horsePower != -1)
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].characteristics.transmissionType != customer.requiredCar.characteristics.transmissionType && 
                    customer.requiredCar.characteristics.transmissionType != "")
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].characteristics.dimensions.length != customer.requiredCar.characteristics.dimensions.length && 
                    customer.requiredCar.characteristics.dimensions.length != -1)
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].characteristics.dimensions.width != customer.requiredCar.characteristics.dimensions.width && 
                    customer.requiredCar.characteristics.dimensions.width != -1)
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].characteristics.dimensions.height != customer.requiredCar.characteristics.dimensions.height && 
                    customer.requiredCar.characteristics.dimensions.height != -1)
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].condition != customer.requiredCar.condition && 
                    customer.requiredCar.condition != "")
                {
                    suitableCars.RemoveAt(i);
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