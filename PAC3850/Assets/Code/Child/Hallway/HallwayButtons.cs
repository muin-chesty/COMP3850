using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class HallwayButtons : MonoBehaviour
{
    [Space]
    public GameObject closingCanvas;
    private bool isClicked = false;
    private float timer = 0f;
    private string sceneName = "";

    private static bool isECGClicked = false;
    private static bool isPathologyClicked = false;
    private static bool isECHOClicked = false;
    private static bool isXRayClicked = false;
    private static bool isHWClicked = false;


    [Header("Play All level panel")]
    [Space]
    public GameObject playAllLevelPanel;
    public void ECG()
    {
        isECGClicked = true;
        sceneName = "ECG1";
        isClicked = true;
        closingCanvas.SetActive(true);
    }
    public void ECHO()
    {
        isECHOClicked = true;
        isClicked = true;
        sceneName = "Echo1";
        closingCanvas.SetActive(true);
    }
    public void Pathology()
    {
        isPathologyClicked = true;
        isClicked = true;
        sceneName = "Pathology1";
        closingCanvas.SetActive(true);
    }
    public void Observation()
    {
      /*  if(isECGClicked && isECHOClicked && isHWClicked && isPathologyClicked &&
            isXRayClicked)
        {*/
            sceneName = "Observation";
            isClicked = true;
            closingCanvas.SetActive(true);
      //  }
       /* else
        {
            playAllLevelPanel.SetActive(true);
        }*/
     
    }
    public void XRay()
    {
        isXRayClicked = true;
        sceneName = "X-Ray";
        isClicked = true;
        closingCanvas.SetActive(true);
    }
    public void HeightAndWeight()
    {
        isHWClicked = true;
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
