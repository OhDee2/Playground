namespace Singleton
{
    public sealed class Singleton
    {
        private Singleton()
        {
            TestString = "Initial";
        }

        public string TestString { get; set; }

        public static Singleton Instance = new Singleton();
    }
}