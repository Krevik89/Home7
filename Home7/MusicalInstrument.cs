using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home7
{
    public class MusicalInstrument
    {
        protected string name;

        public MusicalInstrument(string name)
        {
            this.name = name;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Unknown sound");
        }

        public virtual void Show()
        {
            Console.WriteLine($"Musical instrument: {name}");
        }

        public virtual void Desc()
        {
            Console.WriteLine("No description available");
        }

        public virtual void History()
        {
            Console.WriteLine("No history available");
        }


    }

    public class Violin : MusicalInstrument
    {
        private string material;
        private string size;

        public Violin(string name, string material, string size) : base(name)
        {
            this.material = material;
            this.size = size;
        }

        public override void Sound()
        {
            Console.WriteLine("Violin plays");
        }

        public override void Desc()
        {
            Console.WriteLine($"Violin {name} made of {material} and size {size}");
        }

        public override void History()
        {
            Console.WriteLine("The violin has been around since the 16th century");
        }
    }

    public class Trombone : MusicalInstrument
    {
        private bool valve;

        public Trombone(string name, bool valve) : base(name)
        {
            this.valve = valve;
        }

        public override void Sound()
        {
            Console.WriteLine("Trombone plays");
        }

        public override void Desc()
        {
            Console.WriteLine($"Trombone {name} with {(valve ? "valve" : "slide")} mechanism");
        }

        public override void History()
        {
            Console.WriteLine("The trombone has roots in the 15th century");
        }
    }

    public class Ukulele : MusicalInstrument
    {
        private int frets;

        public Ukulele(string name, int frets) : base(name)
        {
            this.frets = frets;
        }

        public override void Sound()
        {
            Console.WriteLine("Ukulele strums");
        }

        public override void Desc()
        {
            Console.WriteLine($"Ukulele {name} with {frets} frets");
        }

        public override void History()
        {
            Console.WriteLine("The ukulele originated in Hawaii in the late 19th century");
        }
    }

    public class Cello : MusicalInstrument
    {
        private string bowType;

        public Cello(string name, string bowType) : base(name)
        {
            this.bowType = bowType;
        }

        public override void Sound()
        {
            Console.WriteLine("Cello plays");
        }

        public override void Desc()
        {
            Console.WriteLine($"Cello {name} with {bowType} bow");
        }

        public override void History()
        {
            Console.WriteLine("The cello has been around since the 16th century");
        }
    }
}
