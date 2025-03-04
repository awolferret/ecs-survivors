namespace Code.Infrastructure.Registrars
{
    public interface IEntityComponentRegistrar
    {
        void RegisterComponents();
        void UnRegisterComponents();
    }
}