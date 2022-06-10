using Lost.Game.Casting;

namespace Lost.Game.Scripting
{
    public interface Action
    {
        void Execute (Cast cast, Script script, ActionCallback callback);
    }
}