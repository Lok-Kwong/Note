﻿using System.Diagnostics.Contracts;
using System.IO;
using Note.Attributes;

namespace Note
{
    [Author("Manu Puduvalli")]
    public static class FileUtils
    {
        /// <summary>
        /// Returns the size of file in bytes, given an abstract file path.
        /// </summary>
        /// <param name="filePath">The path to the file</param>
        /// <returns>The size of the file in bytes</returns>
        [ContractInvariantMethod]
        [Beta]
        public static long GetFileSize(this string filePath) => new FileInfo(filePath).Length;

        /// <summary>
        /// Returns the size of a directory in bytes, given an abstract file path.
        /// </summary>
        /// <param name="dirPath">The path to the directory</param>
        /// <returns>The size of the directory in bytes</returns>
        [Beta]
        public static long GetDirectorySize(this string dirPath)
        {
            long length = 0;
            FileInfo[] fi_arr = new DirectoryInfo(dirPath).GetFiles();
            DirectoryInfo[] di_arr = new DirectoryInfo(dirPath).GetDirectories();
           
            foreach(FileInfo indv in fi_arr)
            {
                length += indv.Length;
            }
            foreach (DirectoryInfo indv in di_arr)
            {
                length += GetDirectorySize(indv.FullName);
            }
            return length;
        }

        /// <summary>
        /// Returns a pathname to the user's profile folder.
        /// </summary>
        /// <returns>A pathname to the user's profile folder</returns>
        [Beta]
        public static string GetUserPath() => System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile);

        /// <summary>
        /// Returns a pathname to the root directory of the System.
        /// </summary>
        /// <returns>A pathname to the root directory of the System</returns>
        [Beta]
        public static string GetRootPath() => Path.GetPathRoot(System.Environment.SystemDirectory);
    }
}
