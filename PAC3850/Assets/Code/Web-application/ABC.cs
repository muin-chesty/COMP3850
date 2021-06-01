using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABC : MonoBehaviour
{

    JsonObject obj;
    void Start()
    {
        obj = new JsonObject();
        obj.first_name = "Chesty";
        obj.last_name = "Muin";
        obj.sitOnLap = false;
        obj.needParents = true;
        //obj.user = new User("","");
       
        if(obj == null)
        {
            Debug.LogError("File not found");
        }
       //Debug.Log("Routine started");
        StartCoroutine(Upload());
    }



    IEnumerator Upload()
    {
        string api = "https://comp-3850-demo-server.herokuapp.com/api/preferences/add";

        
        string json = JsonUtility.ToJson(obj);

        UnityWebRequest www = UnityWebRequest.Post(api, json);
        //  www.SetRequestHeader("Content-Type", "application/json");
        www.SetRequestHeader("Accept", "application/json");
        www.uploadHandler.contentType = "application/json";
        byte[] bytes = System.Text.Encoding.UTF8.GetBytes(json);
        UploadHandlerRaw uH = new UploadHandlerRaw(bytes);
        www.uploadHandler = uH;
        www.SetRequestHeader("Content-Type", "application/json");
        yield return www.SendWebRequest();
        
        if(www.isHttpError || www.isNetworkError)
        {
            Debug.Log(www.error);
            Debug.Log(www.downloadHandler.text);


        }
        else
        {
           
        }

    }
}
