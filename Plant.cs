using Newtonsoft.Json;

namespace CIS_424_Final
{
    public class Plant
    {
        #region Attributes
        public string Name { get; set; }
        public string Region { get; set; }

        public string Sunlight { get; set; }
        #endregion

        #region Constructors
        [JsonConstructor]
        public Plant(string name, string region, string sunlight)
        {
            this.Name = name;
            this.Region = region;
            this.Sunlight = sunlight;
        }
        #endregion
    }
}
