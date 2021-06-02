using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Echo1Controls : MonoBehaviour
{

    public Renderer shirtOn;
    public Renderer shirtless;
    public Renderer onBed;
    public Renderer dimLights;
    public Renderer pointSwitch;
    public Renderer pointBed;
    public Renderer pointShirt;
    public Renderer checkmark;
    public Text lightsTip1;
    public Text lightsTip2;
    public Text shirtsTip1;
    public Text shirtsTip2;
    public Text bedTip1;
    public Text bedTip2;
    public Renderer Continue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(onBed.enabled == true)
        {
            if(dimLights.enabled == true)
            {
                checkmark.enabled = true;
                pointSwitch.enabled = false;
                lightsTip1.enabled = false;
                lightsTip2.enabled = false;
                Continue.enabled = true;
            }
            else
            {
                checkmark.enabled = false;
                pointSwitch.enabled = true;
                lightsTip1.enabled = true;
                lightsTip2.enabled = true;
                Continue.enabled = false;
            }
        }
        
    }

    public void shirtOff()
    {
        if(shirtOn.enabled == true)
        {
            shirtless.enabled = true;
            shirtOn.enabled = false;
            shirtsTip1.enabled = false;
            shirtsTip2.enabled = false;
            bedTip1.enabled = true;
            bedTip2.enabled = true;
            pointShirt.enabled = false;
            pointBed.enabled = true;
        }
        
    }

    public void lieDown()
    {
        if(shirtless.enabled == true)
        {
            shirtless.enabled = false;
            onBed.enabled = true;
            bedTip1.enabled = false;
            bedTip2.enabled = false;
            pointBed.enabled = false;
        }
    }

    public void lightSwitch()
    {
        if (dimLights.enabled == false)
        {
            dimLights.enabled = true;
        }
        else if (dimLights.enabled == true)
        {
            dimLights.enabled = false;
        }
    }

    public void nextStage()
    {
        if(Continue.enabled == true)
        {
            SceneManager.LoadScene("Echo2");
        }
    }
}
