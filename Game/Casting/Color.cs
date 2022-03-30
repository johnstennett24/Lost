namespace Lost.Game.Casting
{
    public class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;
         public Color(int red, int green, int blue, int alpha = 255)
         {
             this.red = red;
             this.green = green;
             this.blue = blue;
             this.alpha = alpha;
         }

         public int GetAlpha()
         {
             return alpha;
         }

         public int GetBlue()
         {
             return blue;
         }

         public int GetGreen()
         {
             return green;
         }

         public int GetRed()
         {
             return red;
         }
    }
}