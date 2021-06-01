using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowXRay : MonoBehaviour
{
    public GameObject xRay;
    public GameObject showButton;
    public GameObject okButton;
    [Header("Feedback Canvas")]
    [Space]
    public GameObject feedbackCanvas;
    public void ShowXRayImage()
    {
        xRay.SetActive(true);
        showButton.SetActive(false);
    }

    public void NextLevel()
    {
        feedbackCanvas.SetActive(true);
      
    }
}
