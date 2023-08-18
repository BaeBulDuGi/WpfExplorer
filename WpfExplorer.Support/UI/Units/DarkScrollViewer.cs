using System.Windows;
using System.Windows.Controls.Primitives;

namespace WpfExplorer.Support.UI.Units
{
    public class DarkScrollViewer : ScrollBar
    {
        static DarkScrollViewer()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DarkScrollViewer), 
                new FrameworkPropertyMetadata(typeof(DarkScrollViewer)));
        }
    }
}
