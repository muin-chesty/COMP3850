using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Path4Code : MonoBehaviour
{

    public Renderer greyCheck;
    public Renderer blueCheck;
    public Renderer pinkCheck;
    public Renderer Continue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void chooseGrey()
    {
        greyCheck.enabled = true;
        blueCheck.enabled = false;
        pinkCheck.enabled = false;
        Continue.enabled = true;
    }

    public void chooseBlue()
    {
        greyCheck.enabled = false;
        blueCheck.enabled = true;
        pinkCheck.enabled = false;
        Continue.enabled = true;
    }

    public void choosePink()
    {
        greyCheck.enabled = false;
        blueCheck.enabled = false;
        pinkCheck.enabled = true;
        Continue.enabled = true;
    }

    public void nextStage()
    {
        if(Continue.enabled == true)
        {
            SceneManager.LoadScene("Hallway");
        }
    }
}
