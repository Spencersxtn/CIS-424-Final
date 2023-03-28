namespace CIS_424_Final;

using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Security.Principal;

public class UserProfile
{
    //Encapsulation.
    public string Username { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public string Region { get; set; }

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

    //Returns the object formatted nicely as a string.
    public string PrintUser()
    {
        return "Username: " + this.Username + ".\nPassword: " + this.Password + ".\nName: " + this.Name + ".\nRegion: " + this.Region + ".";
    }

    //These update functions will change the object and update the Json file.
    public void UpdateUsername(string path, string value)
    {
        UserProfile userProfile = new(this);
        this.Username = value;
        string text = File.ReadAllText(path);
        text = text.Replace(JsonConvert.SerializeObject(userProfile, Formatting.Indented), JsonConvert.SerializeObject(this, Formatting.Indented));
        File.WriteAllText(path, text);
    }

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
}

