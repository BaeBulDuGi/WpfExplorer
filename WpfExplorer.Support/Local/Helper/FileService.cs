using Jamesnet.Wpf.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using WpfExplorer.Support.Local.Models;

namespace WpfExplorer.Support.Local.Helper
{
    public class FileService
    {
        private readonly DirectoryManager _directoryManager;

        public FileService(DirectoryManager directoryManager)
        {
                _directoryManager = directoryManager;
        }

        public List<FolderInfo> GenerateRootNode()
        {

            List<FolderInfo> roots = new()
            {
               CreateFolderInfo(1, "Download", IconType.ArrowDownBox, _directoryManager.DownloadDirectory),
               CreateFolderInfo(1, "Documents", IconType.TextBox, _directoryManager.DocumentsDirectory),
               CreateFolderInfo(1, "Pictures", IconType.Image, _directoryManager.PicturesDirectory),
            };

            return roots;
        }

        private FolderInfo CreateFolderInfo(
            int depth, string name, IconType icontype, string fullpath)
        {
            return new FolderInfo
            {
                Depth = depth,
                Name = name,
                IcogType = icontype,
                FullPath = fullpath,
                Childern = new()
            };
        }
    }
}
