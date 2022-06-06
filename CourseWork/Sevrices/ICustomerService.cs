using System.Collections.Generic;

namespace CourseWork.Sevrices
{
    public interface ICustomerService
    {
        List<Car> GetSuitableCars(List<Car> cars, Customer customer);
        
        void PutAllCustomersInFile(List<Customer> customers);

        List<Customer> GetALlCustomersFromFile();

        void PutOneCustomerInFile(Customer customer);
    }
}