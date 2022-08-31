using Lost.Game.Casting;
using Lost.Game.Services;


namespace Lost.Game.Scripting
{
    public class InitializeDevicesAction
    {
        private AudioService audioService;
        private VideoService videoService;

        public InitializeDevicesAction(AudioService audioService, VideoService videoService)
        {
            this.audioService = audioService;
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback actionCallback)
        {
            audioService.Initialize();
            videoService.Initialize();

        }

    }
}