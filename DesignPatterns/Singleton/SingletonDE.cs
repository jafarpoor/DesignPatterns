namespace Singleton
{
    public sealed class SingletonDE
    {
        private readonly static Lazy<SingletonDE> uniqSingletonDE = new Lazy<SingletonDE>();
        private SingletonDE()
        {

        }

        public static SingletonDE GetInstance()
        {
            return uniqSingletonDE.Value;
        }
    }
}
