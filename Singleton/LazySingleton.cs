namespace Singleton
{
    // this implementation is thread safe and fast
    public class LazySingleton
    {
        private LazySingleton()
        {
            TestString = "Initial";
        }
        
        public string TestString { get; set; }

        public static LazySingleton Instance => Nested.Instance;

        private static class Nested
        {
            internal static readonly LazySingleton Instance = new LazySingleton();

            static Nested()
            {
            }
        }
    }
}