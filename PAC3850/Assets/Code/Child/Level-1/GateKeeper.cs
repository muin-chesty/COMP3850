using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GateKeeper : MonoBehaviour
{
    public int numOfItems;
    public static int count = 0;

    public GameObject introCanvas;
    public GameObject playButton;
    public GameObject coverImage;


    public GameObject lunchbox;
    public GameObject water;
    public GameObject activity;
    public GameObject meficare;

    public GameObject feedbackCanvas;

    public void ClickPlayButton()
    {
        playButton.SetActive(false);
        introCanvas.SetActive(true);
        coverImage.SetActive(false);


        water.SetActive(true);
        activity.SetActive(true);
        lunchbox.SetActive(true);
        meficare.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(count >= numOfItems)
        {
            feedbackCanvas.SetActive(true);
           
        }
    }
}
