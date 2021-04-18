using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSelect : MonoBehaviour
{

    public Renderer rend;
    public Renderer OtherObject;

    // Start is called before the first frame update
    void Start()
    {
        rend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (rend.enabled == true)
        {
            rend.enabled = false;
        }
        else
        {
            rend.enabled = true;
            OtherObject.enabled = false;
        }
    }
}
