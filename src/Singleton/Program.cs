using System;

namespace Singleton
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Can I use a studio for 1 person? {0}", Studio.Instance.IsStudioAvailable(1) ? "Yes" : "No");
            Console.WriteLine("Can I use a studio for 10 person? {0}", Studio.Instance.IsStudioAvailable(10) ? "Yes" : "No");
            Console.WriteLine("Press any key");
            Console.Read();
        }
    }
}
