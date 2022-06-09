

using System;

namespace CourseWork
{
    public class Customer
    {
        public Guid id;
        public string contacts { get; set; }
        public Car requiredCar { get; set; }
        public int finances { get; set; }

        public Customer(string contacts, Car reqiredCar, int finances)
        {
            id = Guid.NewGuid();
            this.contacts = contacts;
            requiredCar = reqiredCar;
            this.finances = finances;
        }
        
        public Customer(Guid id, string contacts, Car reqiredCar, int finances)
        {
            this.contacts = contacts;
            requiredCar = reqiredCar;
            this.finances = finances;
        }

        public Customer() : this("", new Car(), -1)
        {
        }

    }
}
