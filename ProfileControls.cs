namespace CIS_424_Final;

using Newtonsoft.Json;
using System;

public class UserProfile
{
    //Encapsulation.
    public string Username { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public string Region { get; set; }

    public UserProfile(string username, string password, string name, string region)
    {
        this.Username = username;
        this.Password = password;
        this.Name = name;
        this.Region = region;
    }

    public string PrintUser()
    {
        return "Username: " + this.Username + ".\nPassword: " + this.Password + ".\nName: " + this.Name + ".\nRegion: " + this.Region + ".";
    }
}

