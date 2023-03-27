namespace CIS_424_Final
{
    internal static class Program
    {
        public static string? JsonData;

        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        //This code may need to be adjusted for the final build.
        public static void GetJson()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            for (int i = 0 ; i < 4; i++)
                path = Path.GetDirectoryName(path);
            path = Path.Combine(path, "UserProfiles.json");
            JsonData = File.ReadAllText(path);
        }
    }
}