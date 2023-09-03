namespace _10_Cars_fix
{
    interface IRadio
    {
        void TurnOn();
        void TurnOff();
        void ChangeStation();
        void IncreaseVolume(bool vol);
    }
    interface ISeats
    {
        void AdjustPosition();
        void HeatOn();
        void HeatOff();
    }
    public abstract class Car : IRadio, ISeats
    {
        private bool adjustPosition = false;
        private int radioStation;
        private string? radioName;
        private int volume = 40;
        private bool radioOn = false;
        private string heat = "Off";
        private int speed = 0;
        public int maxSpeed = 180;
        public int gas = 10;
        public int brakes = 10;
        public string choice;
        public virtual void Driving()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Your speed: " + speed);
                    if (radioOn == true)
                    {
                        Console.WriteLine("Station name: " + radioName);
                        Console.WriteLine("Volume: " + volume);
                    }
                    if (adjustPosition == true)
                    {
                        Console.WriteLine("The seat position is adjusted");
                    }
                    Console.WriteLine("Heat " + heat);
                    Console.WriteLine();
                    Console.WriteLine("1 - Gas");
                    Console.WriteLine("2 - Brakes");
                    if (radioOn == false)
                    {
                        Console.WriteLine("3 - Radio on");
                    }
                    else
                    {
                        Console.WriteLine("3 - Radio Off");
                        Console.WriteLine("4 - Change station");
                        Console.WriteLine("5 - Volume +");
                        Console.WriteLine("6 - Volume -");
                    }
                    if (adjustPosition == false)
                    {
                        Console.WriteLine("7 - Adjust position");
                    }
                    Console.WriteLine("8 - Heat On");
                    Console.WriteLine("9 - Heat Off");
                    Console.WriteLine();
                    Console.WriteLine("0 - Exit");
                    Mechanism();
                    if (choice == "0")
                    { return; }
                }
                catch (Exception e) { Console.WriteLine(e.ToString()); }
            }
        }
        public void Mechanism()
        {
            choice = Console.ReadLine();
            try
            {
                switch (choice)
                {
                    case "1":
                        speed += gas;
                        if (speed > maxSpeed)
                        {
                            speed = maxSpeed;
                        };
                        break;
                    case "2":
                        speed -= brakes;
                        if (speed < 0)
                        {
                            speed = 0;
                        }
                        break;
                    case "3":
                        TurnOn();
                        break;
                    case "4":
                        ChangeStation();
                        break;
                    case "5":
                        IncreaseVolume(true);
                        break;
                    case "6":
                        IncreaseVolume(false);
                        break;
                    case "7":
                        AdjustPosition();
                        break;
                    case "8":
                        HeatOn();
                        break;
                    case "9":
                        HeatOff();
                        break;
                    case "0":
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            catch 
            {
                Console.WriteLine("error");
                Console.ReadLine();
            }
        }
        public void TurnOn()

        {
            if (radioOn != false)
            {
                TurnOff();
            }
            else
            {
                radioOn = true;
                Console.WriteLine("Radio On");
                ChangeStation();
            }
        }
        public void TurnOff()
        {
            radioOn = false;
            Console.WriteLine("Radio Off");
        }
        public void ChangeStation()
        {
            if (radioStation == 0)
            {
                Random random = new();
                radioStation = random.Next(1, 5);
            }
            else if (radioStation >= 4)
            {
                radioStation = 1;
            }
            else
            {
                radioStation++;
            }
            switch (radioStation)
            {
                case 1:
                    radioName = "Hit FM ";
                    break;
                case 2:
                    radioName = "Radio ROKS";
                    break;
                case 3:
                    radioName = "KISS FM";
                    break;
                case 4:
                    radioName = "Nashe Radio";
                    break;
                default:
                    Console.WriteLine("Pshhh... psh.. PSHHSHHSHSHS!!!");
                    break;
            }
        }
        public void IncreaseVolume(bool vol)
        {
            if (volume >= 0 && volume <= 100)
            {
                if (vol == true)
                {
                    volume += 10;
                }
                else volume -= 10;
            }
            if (volume > 100)
            {
                volume = 100;
            }
            else if (volume < 0)
            {
                volume = 0;
            }
        }
        public void AdjustPosition()
        {
            adjustPosition = true;
        }
        public void HeatOn()
        {
            heat = "On";
        }
        public void HeatOff()
        {
            heat = "Off";
        }
    }
}
