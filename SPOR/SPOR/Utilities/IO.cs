using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace SPOR.Utilities
{
    public static class IO
    {
        public static IEnumerable<string> GetFolderFilePaths(string folderPath)
        {
            return GetFolderFilePaths(folderPath, "*.*");
        }

        public static IEnumerable<string> GetFolderFilePaths(string folderPath, string searchPattern)
        {
            try
            {
                var folder = new DirectoryInfo(folderPath);

                var files = folder.GetFiles(searchPattern);

                return files.Select(x => x.FullName).ToList();
            }
            catch
            {
                return new List<string>();
            }
        }
    }
}