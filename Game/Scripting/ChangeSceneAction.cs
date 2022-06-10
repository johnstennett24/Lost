using Lost.Game.Casting;
using Lost.Game.Services;


namespace Lost.Game.Scripting
{
    public class ChangeSceneAcituon : Action
    {
        private KeyboardService keyboardservice;
        pricate string nextScene;

        public ChangeSceneAcituon(KeyboardService keyboardservice, string nextScene)
        {
            this.keyboardservice = keyboardservice;
            this.nextScene = nextScene;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            if (keyboardservice.IsKeyPressed(constants.ENTER))
            {
                callback.onNext(nextScene);
            }
        }
    }
}