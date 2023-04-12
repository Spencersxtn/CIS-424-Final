using Newtonsoft.Json;

namespace CIS_424_Final
{
    public class Plant
    {
        #region Attributes
        public string Name { get; set; }
        public string Sunlight { get; set; }
        public string Region { get; set; }
        #endregion

        #region Constructors
        [JsonConstructor]
        public Plant(string name, string sunlight, string region)
        {
            this.Name = name;
            this.Sunlight = sunlight;
            this.Region = region;
        }
        #endregion
    }
}
