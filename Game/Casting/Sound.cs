namespace Lost.Game.Casting
{
    public class Sound
    {
        private string filename;
        private int volume;
        private bool repeated;
        public Sound(string filename, int volume, bool repeated)
        {
            this.filename = filename;
            this.volume = volume;
            this.repeated = repeated;
        }

        public string GetFilename()
        {
            return filename;
        }

        public int GetVolume()
        {
            return volume;
        }

        public bool IsRepeated()
        {
            return repeated;
        }
    }
}