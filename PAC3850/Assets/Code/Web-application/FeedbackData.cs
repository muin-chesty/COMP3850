using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FeedbackData : MonoBehaviour
{

    private float timer = 0f;
    private readonly float transitionalEffectDelay = 1.5f;
    private bool isButtonClicked = false;

    private string emotionalResponseData;

    [Header("Current Level name for hospital staff to make sense of")]
    [Tooltip("Write the name of the current level")]
    public string sceneName;

    [Space]
    [Header("Closing Canvas")]
    [Tooltip("Drag the disabled closing canvas so it can load once feedback is collected")]
    public GameObject closingCanvas;


    [Space]
    [Header("Name of next level")]
    [Tooltip("Drag the name of the level game will go to once gameplay is completed")]
    public string nameOfLevelToGoTo;

    void Start()
    {
      
    }

    public void Relaxed()
    {
        
        emotionalResponseData = "Relaxed";
        isButtonClicked = true;
        
    }
    public void Stressed()
    {
        emotionalResponseData = "Stressed";
      
        isButtonClicked = true;
        // BACKPACK
        // SEND ONE GAMEDATA OBJECT 

        // OBSERVATION
        // SEND ONE GAMEDATA OBJECT


    }
    public void Okay()
    {
        emotionalResponseData = "Okay";
        isButtonClicked = true;
    }
    void Update()
    {
        if(isButtonClicked)
        {
            closingCanvas.SetActive(true);
            timer += Time.deltaTime;
            if (timer >= transitionalEffectDelay)
            {
                SceneManager.LoadScene(nameOfLevelToGoTo);
            }
        }
      
    }
}
