using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HBMaster : MonoBehaviour
{
    public FingerCollision finger;
    [Space]
    public GameObject heartbeatButton;
    [Space]
    public GameObject chest;
    public GameObject stethoscope;
    [Space]
    public GameObject child;
    public GameObject parent;
    [Space]
    public GameObject winPanel;

    private float timer = 0f;
    private float delay = 1f;

    private bool isHBButtonClicked = false;
    private bool isLevelCompleted = false;
    void Update()
    {
        if(finger.oxygenSaturationCompleted && (isHBButtonClicked == false))
        {
            timer += Time.deltaTime;
            if(timer >= delay)
            {
                heartbeatButton.SetActive(true);
                stethoscope.SetActive(true);
            }
        }

        if(isHBButtonClicked)
        {
            if (chest != null && stethoscope != null)
            {
                stethoscope.transform.position =
               Vector2.MoveTowards(stethoscope.transform.position,
               chest.transform.position,
               3f * Time.deltaTime);
            }
        }

        if(isLevelCompleted)
        {
            timer += Time.deltaTime;
            if(timer >= 5f)
            {
                SceneManager.LoadScene("PlayAs");
            }
        }
    }


    public void ClickHBButton()
    {
        isHBButtonClicked = true;
        heartbeatButton.SetActive(false);
        
        timer = 0f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Stethoscope" && gameObject.name == "Chest-Parent")
        {
            collision.gameObject.SetActive(false);
            isLevelCompleted = true;
            winPanel.SetActive(true);
            parent.SetActive(false);
            isHBButtonClicked = false;
            child.SetActive(false);
        }
    }
}
