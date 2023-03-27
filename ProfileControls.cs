namespace CIS_424_Final;
using System;

public class UserProfile
{
    //Base variables. More can be added later.
    private string username;
    private string password;
    private string name;
    private string region;

    //Encapsulation.
    public string Username { get => username; set => username = value; }
    public string Password { get => password; set => password = value; }
    public string Name { get => name; set => name = value; }
    public string Region { get => region; set => region = value; }

    public UserProfile(string username, string password, string name, string region)
    {
        this.username = username;
        this.password = password;
        this.name = name;
        this.region = region;
    }
}

