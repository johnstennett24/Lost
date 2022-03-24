using System;
using Raylib_cs;

namespace Lost.Game.Directing
{
    public class Director
    {

        private bool isPlaying = true;
        public Director()
        {
            
        }

        public void StartGame()
        {   
            while (isPlaying)
            {
                GetInputs();
                Doupdates();
                Dooutputs();
            }
        }

        private void GetInputs()
        {
            Raylib.InitWindow()
        }

        private void Doupdates()
        {

        }

        private void Dooutputs()
        {

        }
    }
}