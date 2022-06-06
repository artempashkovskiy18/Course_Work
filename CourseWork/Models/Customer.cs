using static CourseWork.Car_information;

namespace CourseWork
{
    public class Customer
    {
        public string contacts { get; set; }
        public Car required_car { get; set; }
        public int finances { get; set; }

        public Customer(string contacts, Car reqired_car, int finances)
        {
            this.contacts = contacts;
            this.required_car = reqired_car;
            this.finances = finances;
        }

        public Customer() : this("", new Car(), -1)
        {
        }

    }
}
