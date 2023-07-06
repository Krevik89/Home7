using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home7
{
    public abstract class Worker
    {
        public abstract void Print();
    }

    public class President : Worker
    {
        public override void Print()
        {
            Console.WriteLine("I am the president of the company.");
        }
    }

    public class Security : Worker
    {
        public override void Print()
        {
            Console.WriteLine("I am a security guard.");
        }
    }

    public class Manager : Worker
    {
        public override void Print()
        {
            Console.WriteLine("I am a manager.");
        }
    }

    public class Engineer : Worker
    {
        public override void Print()
        {
            Console.WriteLine("I am an engineer.");
        }
    }
}
