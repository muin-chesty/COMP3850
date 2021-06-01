using System;
using System.Collections;

[Serializable]
public class JsonObject
{

    public string first_name;
    public string last_name;
    public bool sitOnLap;
    public bool needParents;
  //  public User user;

}
[Serializable]

// 1-API FOR CHILD
public static class Child
{
    public static string first_name;
    public static string last_name;
    public static string id;
    public static string dob;
    public static string parent;
    public static string parentReward;
    public static string childReward;
  

}
// 2- API FOR PARENT
public static class Parent
{
    public static string name;
    public static string id;
    public static string question;
}

// 3 - api
public class GameData
{
    public string sceneName;
    public string feedback;
    public string id;

    public GameData(string sName, string fBack)
    {
        sceneName = sName;
        feedback = fBack;
    }
   
}

