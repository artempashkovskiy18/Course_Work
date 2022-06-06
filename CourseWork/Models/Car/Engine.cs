namespace CourseWork
{
    public class Engine
    {
        public int cylinderAmount { get; set; }
        public int volume { get; set; }
        public int horsePower { get; set; }

        public Engine(int cylinderAmount = -1, int volume = -1, int horsePower = -1)
        {
            this.cylinderAmount = cylinderAmount;
            this.volume = volume;
            this.horsePower = horsePower;
        }
    }
}