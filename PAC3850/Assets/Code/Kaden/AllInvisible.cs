using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllInvisible : MonoBehaviour
{

    public Renderer rend1;
    public Renderer rend2;
    public Renderer rend3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void callToInvisible()
    {
        rend1.enabled = false;
        rend2.enabled = false;
        rend3.enabled = false;
    }
}
