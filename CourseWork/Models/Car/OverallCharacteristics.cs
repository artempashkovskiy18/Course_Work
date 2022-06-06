namespace CourseWork
{
    public class OverallCharacteristics
    {
        public Engine engine;
        public string transmissionType;
        public Dimensions dimensions;

        public OverallCharacteristics(Engine engine, string transmissionType, 
            Dimensions dimensions)
        {
            this.engine = engine;
            this.transmissionType = transmissionType;
            this.dimensions = dimensions;
        }

    }
}