namespace otopark
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Giris());
        }
        public static string[] sifreler=new string[] {"123","abc","1"};
        public static string[] kullaniciAdlari=new string[] { "serhat karacasulu", "serhat", "karacasulu"};

    }
}