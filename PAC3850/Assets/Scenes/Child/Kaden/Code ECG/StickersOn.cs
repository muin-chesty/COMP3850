using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StickersOn : MonoBehaviour
{

    public Renderer chest;
    public Renderer arm;
    public Renderer leg;
    public Renderer chestWire;
    public Renderer armWire;
    public Renderer legWire;
    public Renderer chestPoint;
    public Renderer armPoint;
    public Renderer legPoint;
    public Renderer monitorCov1;
    public Renderer monitorCov2;
    public Renderer monitorCov3;
    public Renderer monitorCov4;
    public Renderer monitorCov5;
    public Renderer monitorCov6;
    public Renderer monitorCov7;
    public Renderer Continue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(leg.enabled == true && arm.enabled == true && chest.enabled == true)
        {
            chestWire.enabled = true;
            armWire.enabled = true;
            legWire.enabled = true;
            monitorCov1.enabled = false;
            monitorCov2.enabled = false;
            monitorCov3.enabled = false;
            monitorCov4.enabled = false;
            monitorCov5.enabled = false;
            monitorCov6.enabled = false;
            monitorCov7.enabled = false;
            Continue.enabled = true;
        }
    }

    public void legSticker()
    {
        leg.enabled = true;
        legPoint.enabled = false;
    }

    public void chestSticker()
    {
        chest.enabled = true;
        chestPoint.enabled = false;
    }

    public void armSticker()
    {
        arm.enabled = true;
        armPoint.enabled = false;
    }

    public void nextStage()
    {
        if(Continue.enabled == true)
        {
            SceneManager.LoadScene("Hallway");
        }
    }
}
