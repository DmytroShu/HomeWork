namespace _10_Cars_fix
{
    public class Bmw : Car
    {
        public override void driving()
        {
            maxSpeed = 250;
            gas = 15;
            brakes = 10;

            base.driving();
        }
    }
}
