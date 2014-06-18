using Microsoft.Azure.Jobs;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var host = new JobHost();
                host.RunAndBlock();
            }
        }
    }
}
