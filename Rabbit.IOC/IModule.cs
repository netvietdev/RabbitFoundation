namespace Rabbit.IOC
{
    public interface IModule
    {
        int Index { get; }

        bool IsSatisfied(object condition);
    }
}