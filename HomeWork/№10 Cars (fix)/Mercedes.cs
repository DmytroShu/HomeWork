namespace _10_Cars_fix
{
    public class Mercedes : Car
    {
        public override void driving()
        {
            maxSpeed = 200;
            base.driving();
        }
    }
}
