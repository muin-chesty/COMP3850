using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HallwayButtons : MonoBehaviour
{
    [Space]
    public GameObject closingCanvas;
    private bool isClicked = false;
    private float timer = 0f;
    private string sceneName = "";

    public void ECG()
    {
        
    }
    public void Observation()
    {
        sceneName = "Observation";
        isClicked = true;
        closingCanvas.SetActive(true);
    }
    public void XRay()
    {
        sceneName = "X-Ray";
        isClicked = true;
        closingCanvas.SetActive(true);
    }
    public void HeightAndWeight()
    {
        sceneName = "HeightAndWeight";
        isClicked = true;
        closingCanvas.SetActive(true);
    }
    void Update()
    {
        if(isClicked)
        {
            timer += Time.deltaTime;
            if(timer >= 1f)
            {
                SceneManager.LoadScene(sceneName);
            }

        }
    }
}
