namespace _10_Cars_fix
{
    public class Mercedes : Car
    {
        public override void Driving()
        {
            maxSpeed = 200;
            base.Driving();
        }
    }
}
