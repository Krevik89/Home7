using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home7
{
    public class Device
    {
        protected string name;

        public Device(string name)
        {
            this.name = name;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Unknown sound");
        }

        public virtual void Show()
        {
            Console.WriteLine($"Device: {name}");
        }

        public virtual void Desc()
        {
            Console.WriteLine("No description available");
        }
    }

    public class Kettle : Device
    {
        private int power;

        public Kettle(string name, int power) : base(name)
        {
            this.power = power;
        }

        public override void Sound()
        {
            Console.WriteLine("Kettle whistles");
        }

        public override void Desc()
        {
            Console.WriteLine($"Kettle {name} with power {power}W");
        }
    }

    public class Microwave : Device
    {
        private int power;
        private int capacity;

        public Microwave(string name, int power, int capacity) : base(name)
        {
            this.power = power;
            this.capacity = capacity;
        }

        public override void Sound()
        {
            Console.WriteLine("Microwave beeps");
        }

        public override void Desc()
        {
            Console.WriteLine($"Microwave {name} with power {power}W and capacity {capacity}L");
        }
    }

    public class Car : Device
    {
        private string make;
        private string model;

        public Car(string name, string make, string model) : base(name)
        {
            this.make = make;
            this.model = model;
        }

        public override void Sound()
        {
            Console.WriteLine("Car engine revs");
        }

        public override void Desc()
        {
            Console.WriteLine($"Car {name} made by {make} ({model})");
        }
    }

    public class Ship : Device
    {
        private int displacement;

        public Ship(string name, int displacement) : base(name)
        {
            this.displacement = displacement;
        }

        public override void Sound()
        {
            Console.WriteLine("Ship horn blares");
        }

        public override void Desc()
        {
            Console.WriteLine($"Ship {name} with displacement {displacement} tons");
        }
    }
}
