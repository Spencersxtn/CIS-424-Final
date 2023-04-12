using Newtonsoft.Json;

namespace CIS_424_Final
{
    public static class PlantControl
    {
        #region Methods
        public static void AddPlant(string path, Plant plant)
        {
            if (RetrievePlant(path, plant.Name) != null)
            {
                throw new Exception();
            }

            string text = File.ReadAllText(path);
            text = text.Remove(text.Length - 3, 1);
            text += ",\n" + JsonConvert.SerializeObject(plant, Formatting.Indented) + "\n}";
            File.WriteAllText(path, text);
        }

        public static void DeletePlant(string path, Plant plant)
        {
            if (RetrievePlant(path, plant.Name) == null)
            {
                throw new Exception();
            }

            string text = File.ReadAllText(path);
            text = text.Replace(",\n" + JsonConvert.SerializeObject(plant, Formatting.Indented), "");
            File.WriteAllText(path, text);
        }

        public static Plant RetrievePlant(string path, string name)
        {
            string[] plantData = File.ReadAllText(path).Split('{', '}');
            string plant = Array.Find(plantData, p => p.Contains("\"Name\": \"" + name + "\","));
            return JsonConvert.DeserializeObject<Plant>("{" + plant + "}");
        }

        public static void UpdatePlant(string path, Plant plant)
        {
            Plant oldPlant = RetrievePlant(path, plant.Name);
            string text = File.ReadAllText(path);
            text = text.Replace(JsonConvert.SerializeObject(oldPlant, Formatting.Indented), JsonConvert.SerializeObject(plant, Formatting.Indented));
            File.WriteAllText(path, text);
        }
        #endregion

    }
}
