using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can I use a studio for 1 person? {0}", StudioWithoutLock.Instance.IsStudioAvailable(1) ? "Yes" : "No");
            Console.WriteLine("Can I use a studio for 10 person? {0}", StudioWithoutLock.Instance.IsStudioAvailable(10) ? "Yes" : "No");
            Console.WriteLine("Press any key");
            Console.Read();
        }
    }
}
