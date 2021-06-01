using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ecg1TOecg2 : MonoBehaviour
{
    public Renderer Continue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextLevel()
    {
        if(Continue.enabled == true)
        {
            SceneManager.LoadScene("ECG2");
        }
    }
}
