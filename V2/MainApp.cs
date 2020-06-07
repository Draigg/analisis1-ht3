using System;

namespace V2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Decorator f = new Decorator();
            f.funcCommandLine(args);
        }
    }
}
