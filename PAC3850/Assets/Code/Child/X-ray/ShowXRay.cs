using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowXRay : MonoBehaviour
{
    public GameObject xRay;
    public GameObject showButton;
    public GameObject okButton;

    public void ShowXRayImage()
    {
        xRay.SetActive(true);
        showButton.SetActive(false);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Hallway");
    }
}
