using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Path3Code : MonoBehaviour
{

    public Renderer toyPoint;
    public Renderer phonePoint;
    public Renderer musicPoint;
    public Renderer Continue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pickToy()
    {
        toyPoint.enabled = true;
        phonePoint.enabled = false;
        musicPoint.enabled = false;
        Continue.enabled = true;
    }

    public void pickPhone()
    {
        toyPoint.enabled = false;
        phonePoint.enabled = true;
        musicPoint.enabled = false;
        Continue.enabled = true;
    }

    public void pickMusic()
    {
        toyPoint.enabled = false;
        phonePoint.enabled = false;
        musicPoint.enabled = true;
        Continue.enabled = true;
    }

    public void nextStage()
    {
        if(Continue.enabled == true)
        {
            SceneManager.LoadScene("Pathology4");
        }
    }
}
