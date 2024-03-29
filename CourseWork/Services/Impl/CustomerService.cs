﻿using System.Collections.Generic;
using System.Linq;
using CourseWork.Repositories.Impl;
using CourseWork.Sevrices;
using static CourseWork.CarsFileIndexes;
using static CourseWork.CustomersFileIndexes;

namespace CourseWork
{
    public class CustomerService : ICustomerService
    {
        private CustomerRepository repository = new CustomerRepository();

        //bool methods for checking is car suitable
        private bool CheckBrand(Car car, Customer customer)
        {
            return car.brand == customer.requiredCar.brand || customer.requiredCar.brand == "";
        }
        private bool CheckReleaseYear(Car car, Customer customer)
        {
            return car.releaseYear == customer.requiredCar.releaseYear || customer.requiredCar.releaseYear == -1;
        }
        private bool CheckCylinderAmount(Car car, Customer customer)
        {
            return car.characteristics.engine.cylinderAmount ==
                   customer.requiredCar.characteristics.engine.cylinderAmount ||
                   customer.requiredCar.characteristics.engine.cylinderAmount == -1;
        }
        private bool CheckVolume(Car car, Customer customer)
        {
            return car.characteristics.engine.volume == customer.requiredCar.characteristics.engine.volume ||
                   customer.requiredCar.characteristics.engine.volume == -1;
        }
        private bool CheckHorsePower(Car car, Customer customer)
        {
            return car.characteristics.engine.horsePower == customer.requiredCar.characteristics.engine.horsePower ||
                   customer.requiredCar.characteristics.engine.horsePower == -1;
        }
        private bool CheckTransmissionType(Car car, Customer customer)
        {
            return car.characteristics.transmissionType == customer.requiredCar.characteristics.transmissionType ||
                   customer.requiredCar.characteristics.transmissionType == "";
        }
        private bool CheckLength(Car car, Customer customer)
        {
            return car.characteristics.dimensions.length == customer.requiredCar.characteristics.dimensions.length ||
                   customer.requiredCar.characteristics.dimensions.length == -1;
        }
        private bool CheckWidth(Car car, Customer customer)
        {
            return car.characteristics.dimensions.width == customer.requiredCar.characteristics.dimensions.width ||
                   customer.requiredCar.characteristics.dimensions.width == -1;
        }
        private bool CheckHeight(Car car, Customer customer)
        {
            return car.characteristics.dimensions.height == customer.requiredCar.characteristics.dimensions.height ||
                   customer.requiredCar.characteristics.dimensions.height == -1;
        }
        private bool CheckCondition(Car car, Customer customer)
        {
            return car.condition == customer.requiredCar.condition || customer.requiredCar.condition == "";
        }
        private bool IsCarSuitable(Car car, Customer customer)
        {
            if (car.price <= customer.finances)
            {
                return CheckBrand(car, customer) &&
                       CheckReleaseYear(car, customer) &&
                       CheckCylinderAmount(car, customer) &&
                       CheckVolume(car, customer) &&
                       CheckHorsePower(car, customer) &&
                       CheckTransmissionType(car, customer) &&
                       CheckLength(car, customer) &&
                       CheckWidth(car, customer) &&
                       CheckHeight(car, customer) &&
                       CheckCondition(car, customer);
            }

            return false;
        }
        
        //
        public List<Car> GetSuitableCars(List<Car> cars, Customer customer)
        {
            return cars.Where(car => IsCarSuitable(car, customer))
                .ToList();
        }
        
        
        //saving, getting, editing, removing customers methods
        public void SaveCustomers(List<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                repository.SaveCustomer(customer);
            }
            //repository.PutAllCustomersInFile(customers);
        }
        public List<Customer> GetCustomers()
        {
            return repository.GetAllCustomers();
        }
        public void SaveCustomer(Customer customer)
        {
            repository.SaveCustomer(customer);
        }
        public void DeleteCustomer(Customer customer)
        {
            repository.DeleteCustomer(customer);
        }
        public void EditCustomer(Customer customer)
        {
            repository.EditCustomer(customer);
        }
    }
}