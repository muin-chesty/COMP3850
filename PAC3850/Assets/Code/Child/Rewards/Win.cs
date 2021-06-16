using UnityEngine.Networking;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public GameObject winPanel;
    ChildObject child;

   public InputField parentReward;
   public InputField childReward;

    IEnumerator Upload()
    {
        string api = "https://comp-3850-demo-server.herokuapp.com/api/child/add";


        string json = JsonUtility.ToJson(child);
        Debug.Log(json);
        UnityWebRequest www = UnityWebRequest.Post(api, json);
        //  www.SetRequestHeader("Content-Type", "application/json");
        www.SetRequestHeader("Accept", "application/json");
        www.uploadHandler.contentType = "application/json";
        byte[] bytes = System.Text.Encoding.UTF8.GetBytes(json);
        UploadHandlerRaw uH = new UploadHandlerRaw(bytes);
        www.uploadHandler = uH;
        www.SetRequestHeader("Content-Type", "application/json");
        yield return www.SendWebRequest();

        if (www.isHttpError || www.isNetworkError)
        {
            Debug.Log(www.error);
            Debug.Log(www.downloadHandler.text);


        }


    }
    public void Submit()
    {
        child = new ChildObject();
        Child.childReward = childReward.text;
        Child.parentReward = parentReward.text;
        child.first_name = Child.first_name + "muin ";
        child.last_name = Child.last_name + "muin ";
        child.id = Child.id + 3;
        child.parent = Child.parent +"muin ";
        child.parentReward = Child.parentReward;
        child.dob = Child.dob +"muin ";
        child.childReward = Child.childReward;

        // API-4TH

        winPanel.SetActive(true);
        StartCoroutine(Upload());
    }
}
