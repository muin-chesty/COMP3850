using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParentMenu : MonoBehaviour
{
    private bool isLevelComplete = false;
    private float timer = 0.0f;
    [SerializeField]
    private float delay = 1f;
    [SerializeField]
    private GameObject outroCanvas;
    private string levelName = "";

    public void StartASK()
    {
        isLevelComplete = true;
        levelName = "ASK";
    }
    public void GoBack()
    {
        isLevelComplete = true;
        levelName = "PlayAs";
    }
    public void StartFAQ()
    {
        isLevelComplete = true;
        levelName = "FAQ";
    }

    private void Start()
    {
        outroCanvas.SetActive(false);
    }

    void Update()
    {
        if(isLevelComplete)
        {
            timer += Time.deltaTime;
            outroCanvas.SetActive(true);
            if(timer >= delay)
            {
                SceneManager.LoadScene(levelName);
            }
        }
    }
}
