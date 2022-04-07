namespace Lost.Game.Casting
{
    public class Text
    {
        private string value;
        private string fontFile;
        private int size;
        private int alignment;
        private Color color;

        public Text(string value, string fontFile, int size, int alignment, Color color)
        {
             this.value = value;
             this.fontFile = fontFile;
             this.size = size;
             this.alignment = alignment;
             this.color = color;
        }

        public string GetValue()
        {
            return value;
        }

        public string GetFontFile()
        {
            return fontFile;
        }

        public int GetSize()
        {
            return size;         
        }

        public int GetAlignment()
        {
            return alignment;
        }

        public Color GetColor()
        {
            return color;
        }

        public void SetValue(string value)
        {
            this.value = value;
        }
    }
}