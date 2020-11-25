using System;
using System.Windows.Forms;

namespace csi_analyzers
{
    /// <summary>
    /// General purpose Ulitility class
    /// </summary>
    class Utilities
    {
        private static readonly Random rand = new Random(DateTime.Now.Millisecond);

        /// <summary>
        /// Enable double bufferring for controls to avoid flickering
        /// </summary>
        /// <param name="controlCollection"></param>
        /// <param name="value"></param>
        public static void SetDoubleBuffering(Control.ControlCollection controlCollection, bool value)
        {
            foreach(Control control in controlCollection)
            {
                SetDoubleBuffering(control, value);
            }
        }

        /// <summary>
        /// Returns a txt only FileDialog
        /// </summary>
        /// <returns></returns>
        public static OpenFileDialog GetTextFileDialog()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.txt"; 
            dialog.Multiselect = false;
            return dialog;
        }

        /// <summary>
        /// Gets a random integer
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int GetRandomInt(int min, int max)
        {
            return rand.Next(min, max);
        }

        /// <summary>
        /// Get random detective name
        /// </summary>
        /// <returns></returns>
        public static string GetRandomOfficerName()
        {
            return Constants.NAMES[GetRandomInt(0, 5)];
        }


        private static void SetDoubleBuffering(Control control, bool value)
        {
            System.Reflection.PropertyInfo controlProperty = typeof(Control)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            controlProperty.SetValue(control, value, null);
        }
    }
}
