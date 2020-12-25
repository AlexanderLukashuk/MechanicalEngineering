namespace mechanicalEngineering.Models
{
    public class Engineer
    {
        public Car MekeCar(CarBuilder builder)
        {
            builder.CreateCar();
            builder.AddBody();
            builder.AddBox();
            builder.AddMotor();
            builder.AddWheels();

            return builder.Car;
        }
    }
}