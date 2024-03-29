using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace CIS_424_Final
{
    internal static class Program
    {
        public static string? JsonPath;
        public static string? PlantPath;
        public static List<UserProfile> Users = new();
        public static UserControl UserControl = new();

        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }

        //This function finds the Json file, takes the data from it, and turns it into UserProfile objects.
        public static void GetJson()
        {
            //Find the correct path. This may need to be adjusted for the final build.
            string path = AppDomain.CurrentDomain.BaseDirectory;

            //These lines are not necessary for the release version of the project.
            //for (int i = 0 ; i < 4; i++)
            //    path = Path.GetDirectoryName(path);

            JsonPath = Path.Combine(path, "UserProfiles.json");
            PlantPath = Path.Combine(path, "Plants.json");

            //Read in the data as a string, and convert it to seperate strings.
            string JsonData = File.ReadAllText(JsonPath);
            string[] JsonDataSplit = JsonData.Split('{', '}');

            //Takes the split strings and removes parts in between, converting the rest into UserProfile objects.
            for (int i = 2; i < JsonDataSplit.Length - 2; i += 2)
            {
                UserProfile userProfile = JsonConvert.DeserializeObject<UserProfile>("{" + JsonDataSplit[i] + "}");
                Users.Add(userProfile);
            }
        }
    }
}