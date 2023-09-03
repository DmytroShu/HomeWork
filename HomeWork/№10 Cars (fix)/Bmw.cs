namespace _10_Cars_fix
{
    public class Bmw : Car
    {
        public override void Driving()
        {
            maxSpeed = 250;
            gas = 15;
            brakes = 10;

            base.Driving();
        }
    }
}
