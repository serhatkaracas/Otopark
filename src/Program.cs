namespace otopark
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new kullanici_kayit());
        }
        public static string[] sifreler=new string[] {"a"};
        public static string[] kullaniciAdlari=new string[] {"admin"};

    }
}