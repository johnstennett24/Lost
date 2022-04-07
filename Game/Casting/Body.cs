using Lost.Game.Services;

namespace Lost.Game.Casting
{
    public class Body
    {
        private Point position;
        private Point size;
        private Point velocity;
        public Body(Point position, Point size, Point velocity)
        {
            this.position = position;
            this.size = size;
            this.velocity = velocity;
        }

        public Point GetPosition()
        {
            return position;
        } 

        public Rectangle GetRectangle()
        {
            return new Rectangle(position, size);
        }

        public Point GetSize()
        {
            return size;
        }

        public Point GetVelocity()
        {
            return velocity;
        }

        public void SetSize(Point size)
        {
            this.size = size;
        }

        public void SetVelocity(Point velocity)
        {
            this.velocity = velocity;
        }
    }
}