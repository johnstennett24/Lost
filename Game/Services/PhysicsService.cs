using Lost.Game.Casting;


namespace Lost.Game.Services
{
    public interface PhysicsService
    {
        /// <summary>
        /// Whether or not two bodies have collided.
        /// </summary>
        /// <param name="subject">The first body.</param>
        /// <param name="agent">The second body.</param>
        /// <returns></returns>
        bool HasCollided(Body subject, Body agent);
    }
}