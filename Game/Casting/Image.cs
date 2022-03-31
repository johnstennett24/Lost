namespace Lost.Game.Casting
{
    public class Image
    {
        private string filename;
        private double scale;
        private int rotation;

        public Image(string filename, double scale = 1.0, int rotation = 0)
        {
            this.filename = filename;
            this.scale = scale;
            this.rotation = rotation;
        }

        public string GetFilename()
        {
            return filename;
        }

        public int GetRotation()
        {
            return rotation;
        }

        public double GetScale()
        {
            return scale;
        }

        public void SetRotation(int rotation)
        {
            this.rotation = rotation;
        }

        public void SetScale(double scale)
        {
            this.scale = scale;
        }
        
    }
}