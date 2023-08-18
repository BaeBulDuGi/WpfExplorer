using System;

namespace WpfExplorer
{
    internal class Starter 
    {
        [STAThread]
        static void Main(string [] args)
        {
            _ = new App().Run();
        } 
    }
}
