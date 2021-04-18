using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecificInvis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CallForInvis()
    {
        Debug.Log("pls");
        Debug.Log(gameObject);
        //Renderer tempForInvis = gameObject;
        gameObject.GetComponent<Renderer>().enabled = false;
        //tempForInvis.enabled = false;
        Debug.Log(gameObject.GetComponent<Renderer>().enabled);
    }
}
