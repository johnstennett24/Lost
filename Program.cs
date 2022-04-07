using System;
using Lost.Game.Directing;

namespace Lost
{
    public class Program
    {
       static void Main(string[] args)
       {
           Director director = new Director();
           director.StartGame();
       }
        
    }
}