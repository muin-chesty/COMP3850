using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;

public class MyBehavior : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Routine started");
      //  StartCoroutine(Upload());
    }

/*    IEnumerator Upload()
    {
        List<IMultipartFormSection> formData = new List<IMultipartFormSection>();
        formData.Add(new MultipartFormDataSection("field1=foo&field2=bar"));
        formData.Add(new MultipartFormFileSection("my file data", "myfile.txt"));

        UnityWebRequest www = UnityWebRequest.Post("https://comp-3850-demo-server.herokuapp.com/api/preferences/add", formData);
        yield return www.SendWebRequest();

        *//*        if (www.Resu != UnityWebRequest.Res)
                {
                    Debug.Log(www.error);
                }
                else
                {
                    Debug.Log("Form upload complete!");
                }*//*
    }*/
}