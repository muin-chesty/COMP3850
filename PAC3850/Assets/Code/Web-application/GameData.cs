
using System;

[Serializable]
public class GameData
{
    public  string sceneName;
    public  string feedback;
    public  string id;

    public GameData(string sName, string fBack)
    {
        sceneName = sName;
        feedback = fBack;
    }

}
