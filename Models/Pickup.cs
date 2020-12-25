namespace mechanicalEngineering.Models
{
    public class Pickup : CarBuilder
    {
        public override void AddBody()
        {
            Car.Body = new Body() { Name = "Кузов для пикапа"};
        }
        public override void AddBox()
        {
            Car.Box = new Box() { Name = "Коробка для пикапа"};
        }
        public override void AddMotor()
        {
            Car.Motor = new Motor() { Name = "Мотор для пикапа"};
        }
        public override void AddWheels()
        {
            Car.Wheels = new Wheels() { Name = "Колеса для пикапа"};
        }
    }
}