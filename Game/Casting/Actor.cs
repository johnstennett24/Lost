namespace Lost.Game.Casting
{
    public class Actor
    {
        private bool debug;

        public Actor( bool debug)
        {
            this.debug = debug;
        }

        public bool IsDebug()
        {
            return debug;
        }
    }
}