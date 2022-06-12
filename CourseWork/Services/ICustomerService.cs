using System.Collections.Generic;

namespace CourseWork.Sevrices
{
    public interface ICustomerService
    {
        List<Car> GetSuitableCars(List<Car> cars, Customer customer);
        
        void SaveCustomers(List<Customer> customers);

        List<Customer> GetCustomers();

        void SaveCustomer(Customer customer);

        void DeleteCustomer(Customer customer);
        
        void EditCustomer(Customer customer);
    }
}