

namespace CourseWork
{
    public class Customer
    {
        public string contacts { get; set; }
        public Car requiredCar { get; set; }
        public int finances { get; set; }

        public Customer(string contacts, Car reqiredCar, int finances)
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
