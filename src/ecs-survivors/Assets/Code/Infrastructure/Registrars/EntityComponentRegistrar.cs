using Code.Infrastructure.View;

namespace Code.Infrastructure.Registrars
{
    public abstract class EntityComponentRegistrar : EntityDependant, IEntityComponentRegistrar
    {
        public abstract void RegisterComponents();
        public abstract void UnRegisterComponents();
    }
}