﻿namespace Tyrrrz.Settings
{
    /// <summary>
    /// Configuration object for the SettingsManager class
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// Determines where the settings files will be stored
        /// </summary>
        public enum StorageSpace
        {
            /// <summary>
            /// The settings file is stored in %appdata% folder
            /// </summary>
            RoamingAppData,

            /// <summary>
            /// The settings file is stored in %localappdata% folder
            /// </summary>
            LocalAppData,

            /// <summary>
            /// The settings file is stored in My Documents folder
            /// </summary>
            MyDocuments
        }

        /// <summary>
        /// Subdirectory path for where the settings file is stored, relative to the selected StorageSpace
        /// </summary>
        public string SubdirectoryPath { get; }

        /// <summary>
        /// Type of storage, where the settings file will be stored
        /// </summary>
        public StorageSpace FileStorageSpace { get; }

        /// <summary>
        /// Name of the settings file
        /// </summary>
        public string FileName { get; }

        /// <summary>
        /// Creates a settings manager configuration object with given values
        /// </summary>
        public Configuration(
            string subdirectoryPath = "",
            string fileName = "Settings.dat",
            StorageSpace fileStorageSpace = StorageSpace.RoamingAppData)
        {
            SubdirectoryPath = subdirectoryPath;
            FileName = fileName;
            FileStorageSpace = fileStorageSpace;
        }
    }
}