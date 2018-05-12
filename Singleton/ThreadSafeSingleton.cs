namespace Singleton
{
    public sealed class ThreadSafeSingleton
    {
        private ThreadSafeSingleton()
        {
            TestString = "Initial";
        }

        public string TestString { get; set; }

        public static readonly ThreadSafeSingleton Instance = new ThreadSafeSingleton();
    }
}