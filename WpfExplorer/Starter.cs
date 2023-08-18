using System;
using WpfExplorer.Forms.Properties;
using WpfExplorer.Properties;

namespace WpfExplorer
{
    internal class Starter 
    {
        [STAThread]
        static void Main(string [] args)
        {
            _ = new App()
                .AddInversionModule<HelperModules>()
                .AddInversionModule<ViewModels>() 
                .AddWireDataContext<WireDataContext>()
                .Run();
        } 
    }
}
