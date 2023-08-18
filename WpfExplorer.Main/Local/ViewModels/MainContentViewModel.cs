using System.Collections.Generic;
using System.Windows.Documents;
using WpfExplorer.Support.Local.Helper;
using WpfExplorer.Support.Local.Models;

namespace WpfExplorer.Main.Local.ViewModels
{
    public class MainContentViewModel
    {
        public List<FolderInfo> Roots { get; init; }

        public MainContentViewModel(FileService fileService)
        {
            Roots = fileService.GenerateRootNode();
        }
    }
}
