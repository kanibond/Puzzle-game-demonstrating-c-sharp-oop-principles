using System;
using System.Drawing;


namespace csi_analyzers
{
    /// <summary>
    /// Static class containing App-wide constants
    /// </summary>
    static class Constants
    {
        public static string[] NAMES = {"Max Payne", "Frank Price", "Robert Walker", "Sam Law", "Thomas Hayes"};

        public static string INSTRUCTIONS => "Incoming transmission....\nDecrypting message....\n\nDATE: " +
            $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss zzz")}\n\n\nHello detective, we apologize for the short notice. " +
             "Crime still overwhelms Gotham City. We need you to investigate the murders of fellow " +
            "police officers who have fallen victims to the Not The Joker. Since we have very advanced tech, " +
            "you do not need to be physically present at the crime scene. Rather, we have sent you " +
            "a live, interactive 2D map of the crime scene. Use it to collect evidence to solve the " +
            "murder mysteries.\n\nIn addition, we have given you the option to import your own crime " +
            "scene in the Settings page. Different crime scenes vary in difficulty, as some murders are " +
            "more mysterious than others.\n\nBe careful, detective. We have a limited window before the " +
            "Not The Joker strikes again. So, be sure to keep an eye on the timer.\n\nWe are counting on " +
            "you. Gotham City is counting on you... Good luck, detective.\n\n\nHQ";

        // colors
        public static Color PRIMARY_COLOR => Color.CornflowerBlue;
        public static Color SECONDARY_COLOR => Color.White;

        // local storage keys
        public static string DIFFICULTY_KEY => "difficulty";
        public static string CAN_IMPORT_KEY => "canImport";
        public static string IMPORTED_SCENES_PATH_KEY => "importedScenesPath";

        // messages
        public static string YOU_FAILED => "You failed Gotham City. Would you like to restart?";
        public static string MISSION_FAILED => "MISSION FAILED";

        // grid sizes
        public static int GRID_BUTTON_SIZE => 48;
        public static Size GRID_EASY_SIZE => new Size(5, 10);
        public static Size GRID_MEDIUM_SIZE => new Size(15, 25);
        public static Size GRID_HARD_SIZE => new Size(25, 40);


    }

}
