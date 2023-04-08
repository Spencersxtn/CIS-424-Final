namespace CIS_424_Final;
using Newtonsoft.Json;
using System.IO;

public class UserProfile
{
    //Encapsulation.
    public string Username { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public string Region { get; set; }

    //Default constructor and Copy constructor
    #region Constructors
    [JsonConstructor]
    public UserProfile(string username, string password, string name, string region)
    {
        this.Username = username;
        this.Password = password;
        this.Name = name;
        this.Region = region;
    }

    public UserProfile(UserProfile userProfile)
    {
        this.Username = userProfile.Username;
        this.Password = userProfile.Password;
        this.Name = userProfile.Name;
        this.Region = userProfile.Region;
    }
    #endregion Constructors

    //Returns the object formatted nicely as a string.
    public string PrintUser()
    {
        return "Username: " + this.Username + ".\nPassword: " + this.Password + ".\nName: " + this.Name + ".\nRegion: " + this.Region + ".";
    }

    //Run this after creating a new user, and it will update the Json file.
    public void AddUser(string path)
    {
        string text = File.ReadAllText(path);
        text = text.Remove(text.Length - 3, 1);
        text = text + ",\n" + JsonConvert.SerializeObject(this, Formatting.Indented) + "\n}";
        File.WriteAllText(path, text);
    }

    //This overload will check if there is any user already in the file with this username.
    public bool AddUser(string path, string username)
    {
        string text = File.ReadAllText(path);
        if (text.Contains("\"Username\": \"" +  username + "\","))
            return false;
        text = text.Remove(text.Length - 3, 1);
        text = text + ",\n" + JsonConvert.SerializeObject(this, Formatting.Indented) + "\n}";
        File.WriteAllText(path, text);
        return true;
    }

    //Run this right before deleting/removing the object to update the Json file.
    public void DeleteUser(string path)
    {
        string text = File.ReadAllText(path);
        text = text.Replace(",\n" + JsonConvert.SerializeObject(this, Formatting.Indented), "");
        File.WriteAllText(path, text);
    }

    //These update functions will change the object and update the Json file.
    #region Update Functions
    public void UpdatePassword(string path, string value)
    {
        UserProfile userProfile = new(this);
        this.Password = value;
        string text = File.ReadAllText(path);
        text = text.Replace(JsonConvert.SerializeObject(userProfile, Formatting.Indented), JsonConvert.SerializeObject(this, Formatting.Indented));
        File.WriteAllText(path, text);
    }

    public void UpdateName(string path, string value)
    {
        UserProfile userProfile = new(this);
        this.Name = value;
        string text = File.ReadAllText(path);
        text = text.Replace(JsonConvert.SerializeObject(userProfile, Formatting.Indented), JsonConvert.SerializeObject(this, Formatting.Indented));
        File.WriteAllText(path, text);
    }

    public void UpdateRegion(string path, string value)
    {
        UserProfile userProfile = new(this);
        this.Region = value;
        string text = File.ReadAllText(path);
        text = text.Replace(JsonConvert.SerializeObject(userProfile, Formatting.Indented), JsonConvert.SerializeObject(this, Formatting.Indented));
        File.WriteAllText(path, text);
    }
    #endregion Update Functions
}

