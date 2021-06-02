using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Echo3Controls : MonoBehaviour
{

    public Renderer blueyPoint;
    public Renderer wigglesPoint;
    public Renderer doraPoint;
    public Renderer Continue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(blueyPoint.enabled == true || wigglesPoint.enabled == true ||
            doraPoint.enabled == true)
        {
            Continue.enabled = true;
        }
    }

    public void selectBluey()
    {
        blueyPoint.enabled = true;
        wigglesPoint.enabled = false;
        doraPoint.enabled = false;
    }

    public void selectWiggles()
    {
        blueyPoint.enabled = false;
        wigglesPoint.enabled = true;
        doraPoint.enabled = false;
    }

    public void selectDora()
    {
        blueyPoint.enabled = false;
        wigglesPoint.enabled = false;
        doraPoint.enabled = true;
    }

    public void nextStage()
    {
        if(Continue.enabled == true)
        {
            SceneManager.LoadScene("Hallway");
        }
    }
}
