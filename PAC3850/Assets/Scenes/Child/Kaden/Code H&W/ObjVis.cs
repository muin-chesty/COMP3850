using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjVis : MonoBehaviour
{

    public Renderer CharOnScale;
    public Renderer ScaleCheckmark;
    public Renderer ScaleTip;
    public Renderer ScaleTipArrow;
    public Text ScaleTipText;
    public Renderer CharToMeasure;
    public Renderer MeasureCheckmark;
    public Renderer MeasureTip;
    public Renderer MeasureTipArrow;
    public Text MeasureTipText;
    public Renderer Continue;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(ScaleCheckmark.enabled == true && MeasureCheckmark.enabled == true)
        {
            Continue.enabled = true;
        }
    }

    public void OnScale()
    {
        if(ScaleCheckmark.enabled != true)
        {
            if (CharToMeasure.enabled == true)
            {
                CharToMeasure.enabled = false;
            }
            ScaleTipText.enabled = false;
            ScaleTip.enabled = false;
            ScaleTipArrow.enabled = false;
            CharOnScale.enabled = true;
            ScaleCheckmark.enabled = true;
        }
    }

    public void ToMeasure()
    {
        if(MeasureCheckmark.enabled != true)
        {
            if (CharOnScale.enabled == true)
            {
                CharOnScale.enabled = false;
            }
            MeasureTipText.enabled = false;
            MeasureTip.enabled = false;
            MeasureTipArrow.enabled = false;
            CharToMeasure.enabled = true;
            MeasureCheckmark.enabled = true;
        }
    }
}
