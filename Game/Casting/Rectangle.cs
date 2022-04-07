namespace Lost.Game.Casting
{
    public class Rectangle
    {
        private Point position;
        private Point size;


        public Rectangle(Point position, Point size)
        {
            this.position = position;
            this.size = size;
        }

        public Point GetPosition()
        {
            return position;
        }

        public Point GetSize()
        {
            return size;
        }
    }
}