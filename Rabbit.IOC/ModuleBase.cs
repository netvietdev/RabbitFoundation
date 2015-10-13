namespace Rabbit.IOC
{
    public abstract class ModuleBase : IModule
    {
        public virtual int Index
        {
            get { return int.MaxValue; }
        }

        public virtual bool IsSatisfied(object condition)
        {
            return true;
        }
    }
}