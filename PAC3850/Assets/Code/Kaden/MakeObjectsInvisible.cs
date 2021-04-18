using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeObjectsInvisible : MonoBehaviour
{

    public Renderer rend1;
    public Renderer rend2;
    public Renderer rend3;
    public Renderer rend1Selected;
    public Renderer rend2Selected;
    public Renderer rend3Selected;


    // Start is called before the first frame update
    void Start()
    {
        rend1.enabled = false;
        rend2.enabled = false;
        rend3.enabled = false;
        rend1Selected.enabled = false;
        rend2Selected.enabled = false;
        rend3Selected.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("test");

        /*
        if(Input.GetMouseButtonDown(0))
        {
            if (rend1.enabled == false)
            {
                rend1.enabled = true;
                rend2.enabled = false;
                rend3.enabled = false;
            }
        }
        */
    }

    void OnMouseDown()
    {
        if(rend1.enabled == false)
        {
            rend1.enabled = true;
            rend2.enabled = false;
            rend3.enabled = false;
            rend1Selected.enabled = true;
            rend2Selected.enabled = false;
            rend3Selected.enabled = false;
        }
    }
}
