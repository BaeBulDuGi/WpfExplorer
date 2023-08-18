using Prism.Ioc;
using Prism.Modularity;
using WpfExplorer.Forms.Local.Helper;

namespace WpfExplorer.Forms.Properties
{
    class HelperModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<DirectoryManager>();
        }
    }
}
