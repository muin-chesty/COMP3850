using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shirtOff : MonoBehaviour
{

    public Renderer shirtOn;
    public Renderer shirtless;   
    public Renderer Continue;
    public Renderer tipWindow;
    public Renderer tipArrow;
    public Renderer checkmark;
    public Text tip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeShirtOff()
    {
        shirtOn.enabled = false;
        shirtless.enabled = true;
        Continue.enabled = true;
        tipWindow.enabled = false;
        tipArrow.enabled = false;
        tip.enabled = false;
        checkmark.enabled = true;
    }
}
