using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace _7_Cars
{
    public abstract class Car
    {
        public int speed = 0;
        public int maxSpeed = 180;
        public int gas = 10;
        public int brakes = 10;
        public string choice;
        public virtual void driving()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Your speed: " + speed);
                Console.WriteLine();
                Console.WriteLine("1 - Gas");
                Console.WriteLine("2 - Brakes");
                Console.WriteLine();
                Console.WriteLine("0 - Exit");
                Mechanism();
                if (choice == "0")
                { return; }
            }
        }
        public void Mechanism()
        {
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    speed = speed + gas;
                    if (speed > maxSpeed)
                    {
                        speed = maxSpeed;
                    };
                    break;
                case "2":
                    speed = speed - brakes;
                    if (speed < 0)
                    {
                        speed = 0;
                    }
                    break;
                case "0":
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
    public class Mercedes : Car
    {
        public Mercedes()
        {
            maxSpeed = 200;
        }
        public override void driving()
        {
            base.driving();
        }
    }
    public class BMW : Car
    {
        public BMW()
        {
            maxSpeed = 250;
            gas = 15;
            brakes = 10;
        }
        public override void driving()
        {
            base.driving();
        }
    }
    public class Volkswagen : Car
    {
        public Volkswagen()
        {
            maxSpeed = 220;
            gas = 10;
            brakes = 15;
        }
        public override void driving()
        {
            base.driving();
        }
    }
}
