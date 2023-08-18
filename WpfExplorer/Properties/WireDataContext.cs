using Jamesnet.Wpf.Global.Location;
using WpfExplorer.Forms.Local.ViewModels;
using WpfExplorer.Forms.UI.Views;
using WpfExplorer.Main.Local.ViewModels;
using WpfExplorer.Main.UI.Views;

namespace WpfExplorer.Forms.Properties
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<MainContent, MainContentViewModel>();
            items.Register<ExplorerWindow, ExplorerViewModel>();
        }
    }
}
