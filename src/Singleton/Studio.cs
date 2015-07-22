namespace Singleton
{
    internal class Studio
    {
        // Keeping thread safety without using locks, there's obviously several ways to implement this, for a further explanation check: http://csharpindepth.com/Articles/General/Singleton.aspx
        private static readonly Studio instance = new Studio();
        public static Studio Instance
        {
            get { return instance; }
        }

        static Studio() { }

        private Studio()
        {
        }

        public bool IsStudioAvailable(int persons)
        {
            // Insert your logic
            return true;
        }

    }
}
