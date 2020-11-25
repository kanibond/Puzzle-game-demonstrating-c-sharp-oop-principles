using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using WMPLib;
using System.IO;

namespace csi_analyzers
{
    /// <summary>
    /// Singleton Class that controls music and sound througout the application
    /// </summary>
    class SoundControl
    {
        /* **************************** Member Data **************************** */

        private readonly SoundPlayer mainPlayer;
        private readonly WindowsMediaPlayer effectsPlayer;
        private readonly string musicPath;
        private readonly string mainTheme;
        private readonly string inGameTheme;
        private readonly string defaultButtonEffect;
        private readonly string cancelButtonEffect;
        private readonly string hoverButtonEffect;
        private static SoundControl soundControl;

        /* **************************** Constructors **************************** */

        private SoundControl()
        {
            Console.WriteLine("Initializing.");
            musicPath = @"sfx\";
            mainTheme = "main.wav";
            inGameTheme = "game.wav";
            defaultButtonEffect = "defaultButton.wav";
            cancelButtonEffect = "cancelButton.wav";
            hoverButtonEffect = "hover.wav";
            mainPlayer = new SoundPlayer();
            effectsPlayer = new WindowsMediaPlayer();

        }

        /* **************************** Properties **************************** */

        /// <summary>
        /// Lazy Instance of Singleton
        /// </summary>
        public static SoundControl Instance => soundControl ?? (soundControl = new SoundControl());

        /* **************************** Methods **************************** */

        /// <summary>
        /// Plays the Main Menu theme of the game
        /// </summary>
        public void PlayTheme(SoundType type)
        {
            switch (type)
            {
                case SoundType.MainTheme:
                    mainPlayer.SoundLocation = $"{musicPath}{mainTheme}";
                    break;

                case SoundType.InGameTheme:
                    mainPlayer.SoundLocation = $"{musicPath}{inGameTheme}";
                    break;
            }
            try
            {
                mainPlayer.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error playing sound");
            }
        }

        /// <summary>
        /// Stops playing Main Menu theme
        /// </summary>
        public void StopTheme()
        {
            mainPlayer.Stop();
        }

        /// <summary>
        /// Plays a specific SFX
        /// </summary>
        /// <param name="type"></param>
        public void PlayEffect(SoundType type)
        {
            switch (type)
            {
                case SoundType.DefaultEffect:
                    effectsPlayer.URL = CombinePath(defaultButtonEffect);
                    break;

                case SoundType.CancelEffect:
                    effectsPlayer.URL = CombinePath(cancelButtonEffect);
                    break;

                case SoundType.HoverEffect:
                    effectsPlayer.URL = CombinePath(hoverButtonEffect);
                    break;
            }
        }

        public string CombinePath(string effectPath)
        {
            return Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),
                                                      musicPath, effectPath);
        }
        

        public enum SoundType
        {
            DefaultEffect,
            CancelEffect,
            HoverEffect,
            MainTheme,
            InGameTheme
        }
    }

    
}
