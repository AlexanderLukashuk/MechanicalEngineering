using System;

namespace mechanicalEngineering.Models
{
    public class Car
    {
        public Body Body { get; set; }
        public Box Box { get; set; }
        public Motor Motor { get; set; }
        public Wheels Wheels { get; set; }

        public override string ToString()
        {
            string result = Body.Name + Environment.NewLine +
                    Box.Name + Environment.NewLine +
                    Motor.Name + Environment.NewLine +
                    Wheels.Name + Environment.NewLine;
            return result;
        }
    }
}