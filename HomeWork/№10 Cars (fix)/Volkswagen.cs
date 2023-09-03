namespace _10_Cars_fix
{
    public class Volkswagen : Car
    {

        public override void Driving()
        {

            maxSpeed = 220;
            gas = 10;
            brakes = 15;

            base.Driving();
        }
    }
}
