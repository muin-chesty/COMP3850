using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToNextLevel : MonoBehaviour
{
    public Renderer Continue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartNextLevel()
    {
        if (Continue.enabled == true)
        {
            Debug.Log("LOAD NEXT LEVEL HERE");
        }
    }
}
