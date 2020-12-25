namespace mechanicalEngineering.Models
{
    public abstract class CarBuilder
    {
        public Car Car { get; set; }

        public void CreateCar()
        {
            Car = new Car();
        }

        public abstract void AddBody();
        public abstract void AddBox();
        public abstract void AddMotor();
        public abstract void AddWheels();
    }
}