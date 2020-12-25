namespace mechanicalEngineering.Models
{
    public class Truck : CarBuilder
    {
        public override void AddBody()
        {
            Car.Body = new Body() { Name = "Кузов для грузовика"};
        }
        public override void AddBox()
        {
            Car.Box = new Box() { Name = "Коробка для грузовика"};
        }
        public override void AddMotor()
        {
            Car.Motor = new Motor() { Name = "Мотор для грузовика"};
        }
        public override void AddWheels()
        {
            Car.Wheels = new Wheels() { Name = "Колеса для грузовика"};
        }
    }
}