using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csi_analyzers
{
    /// <summary>
    /// Holds all settings and stores in local storage.
    /// Singleton Class
    /// </summary>
    public class Settings
    {

        /* **************************** Member Data **************************** */

        private static Settings settings;   // instance
        private readonly Properties.Settings preferences;

        /* **************************** Constructors **************************** */

        private Settings()
        {
            preferences = Properties.Settings.Default;
            RetrieveSettings();
        }

        /* **************************** Properties **************************** */

        /// <summary>
        /// Retrieves lazy instance
        /// </summary>
        public static Settings Instance => settings ?? (settings = new Settings());

        public GameDifficulty Difficulty { get; private set; }
        public string ImportedScenesPath { get; private set; }
        public bool CanImport { get; private set; }

        /* **************************** Methods **************************** */

        /// <summary>
        /// Saves settings in local storage
        /// </summary>
        /// <param name="difficulty"></param>
        /// <param name="canImport"></param>
        /// <param name="importedScenesPath"></param>
        public void SaveSettings(GameDifficulty difficulty, bool canImport = false, string importedScenesPath = "")
        {
            Difficulty = difficulty;
            preferences[Constants.DIFFICULTY_KEY] = (int)difficulty;
            preferences[Constants.CAN_IMPORT_KEY] = CanImport = canImport;
            preferences[Constants.IMPORTED_SCENES_PATH_KEY] = ImportedScenesPath = importedScenesPath;
            preferences.Save();
        }

        /// <summary>
        /// Retrieves settings from local storage
        /// </summary>
        private void RetrieveSettings()
        {
            Difficulty = (GameDifficulty)preferences[Constants.DIFFICULTY_KEY];
            CanImport = (bool)preferences[Constants.CAN_IMPORT_KEY];
            ImportedScenesPath = (string)preferences[Constants.IMPORTED_SCENES_PATH_KEY];
        }

        /// <summary>
        /// Specifies the type of game played
        /// </summary>
        public enum GameType
        {
            Fingerprint,
            DNA,
            Blood
        }

        /// <summary>
        /// Specifies the difficulty
        /// </summary>
        public enum GameDifficulty
        {
            Easy,
            Medium,
            Hard
        }
    }
}
