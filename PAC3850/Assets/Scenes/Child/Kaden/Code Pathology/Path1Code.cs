using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Path1Code : MonoBehaviour
{

    public Renderer standingKid;
    public Renderer sittingKid;
    public Renderer Continue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sitDown()
    {
        standingKid.enabled = false;
        sittingKid.enabled = true;
        Continue.enabled = true;
    }

    public void nextStage()
    {
        if(Continue.enabled == true)
        {
            SceneManager.LoadScene("Pathology2");
        }
    }
}
