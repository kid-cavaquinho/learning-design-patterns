namespace Creational.Singleton
{
    public sealed class StudioWithoutLock
    {
        // Keeping thread safety without using locks, there's obviously several ways to implement this, for a further explanation check: http://csharpindepth.com/Articles/General/Singleton.aspx
        private static readonly StudioWithoutLock instance = new StudioWithoutLock();
        public static StudioWithoutLock Instance
        {
            get { return instance; }
        }

        static StudioWithoutLock() { }

        private StudioWithoutLock() { }

        public bool IsStudioAvailable(int persons)
        {
            // Insert your logic
            return true;
        }
    }
}
