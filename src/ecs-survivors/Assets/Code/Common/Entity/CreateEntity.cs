namespace Code.Common.Entity
{
    public class CreateEntity
    {
        public static GameEntity Empty() =>
            Contexts.sharedInstance.game.CreateEntity();
    }
}