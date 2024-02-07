using System;

namespace Week13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new ModernFactory());
            client.Run();
        }
    }
}
