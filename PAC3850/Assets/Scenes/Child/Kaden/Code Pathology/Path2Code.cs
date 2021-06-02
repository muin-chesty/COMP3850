using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Path2Code : MonoBehaviour
{

    public Renderer tourniquet;
    public Renderer point;
    public Renderer Continue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tourniquetOn()
    {
        tourniquet.enabled = true;
        point.enabled = false;
        Continue.enabled = true;
    }

    public void nextStage()
    {
        if(Continue.enabled == true)
        {
            SceneManager.LoadScene("Pathology3");
        }
    }
}
