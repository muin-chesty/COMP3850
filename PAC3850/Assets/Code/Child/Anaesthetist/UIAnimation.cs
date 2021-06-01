using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIAnimation : MonoBehaviour
{
    private float timer = 0f;
    private float delay = 1f;
    private bool levelGreetings = true;

    private bool endInfoReady = true;

    private float gameEndingTimer = 0.0f;
    private float gameEndDelay = 13f;

    public GameObject introUpPanel;
    public GameObject introDownPanel;

    [Header("Child and Parent")]
    [Space]
    public GameObject player;
    public GameObject parent;
    [Header("Play Button")]
    [Space]
    public GameObject playButton;
    private bool isPlayButtonClicked = false;

    [Header("Oxygen Button")]
    [Space]
    public GameObject oxygenButton;
    private bool isOxygenButtonClicked = false;

    [Header("Stethoscope Button")]
    [Space]
    public GameObject stethoscopeButton;
    private bool isStethoscopeButtonClicked = false;

    [Header("Minigame Objects")]
    [Space]
    public GameObject stethoscope;
    public GameObject oxygenMask;

    [Header("Info Panels")]
    [Space]
    public GameObject upInfoPanel;
    public GameObject downInfoPanel;

    [Header("Move Scripts")]
    [Space]
    public MoveMask mask;
    public StethoscopeMove stMove;

    [Header("Win Panel")]
    [Space]
    public GameObject winPanel;

    [Header("Feedback Canvas")]
    [Space]
    public GameObject feedbackCanvas;
    void Update()
    {

        if(mask.GetMaskTaskCompleted() && stMove.GetHBCompleted() && endInfoReady)
        {
            gameEndingTimer += Time.deltaTime;
            if(gameEndingTimer >= 1f)
            {
                if (parent.activeSelf)
                {
                    parent.SetActive(false);
                }
                if (player.activeSelf)
                {
                    player.SetActive(false);
                }
                upInfoPanel.SetActive(true);
                if(gameEndingTimer >= 2f)
                {
                    upInfoPanel.SetActive(false);
                    downInfoPanel.SetActive(true);
                    if(gameEndingTimer >= gameEndDelay + 2f)
                    {
                        downInfoPanel.SetActive(false);
                        endInfoReady = false;
                        gameEndDelay = 4f;
                        gameEndingTimer = 0f;
                    }
                }
            }
        }

        if(endInfoReady == false)
        {
            
            winPanel.SetActive(true);
            gameEndingTimer += Time.deltaTime;
            if(parent.activeSelf)
            {
                parent.SetActive(false);
            }
            if(player.activeSelf)
            {
                player.SetActive(false);
            }
            if(gameEndingTimer >= gameEndDelay)
            {

                // ACTIVATE FEEDBACK CANVAS
                feedbackCanvas.SetActive(true);
            }
        }
        if(levelGreetings)
        {
            timer += Time.deltaTime;
            if(timer >= delay)
            {
                introUpPanel.SetActive(false);
                introDownPanel.SetActive(true);
                if(timer >= (delay + 11f))
                {
                    introDownPanel.SetActive(false);
                    timer = 0f;
                    levelGreetings = false;
                    parent.SetActive(true);
                    player.SetActive(true);
                    playButton.SetActive(true);
                    
                }
            }
        }
    }

    public bool GetPlayButtonClicked()
    {
        return isPlayButtonClicked;
    }
    public bool GetStethoscopeButtonClicked()
    {
        return isStethoscopeButtonClicked;
    }
    public bool GetOxygenButtonClicked()
    {
        return isOxygenButtonClicked;
    }
    public void ClickPlayButton()
    {
        playButton.SetActive(false);
        stethoscope.SetActive(true);
        oxygenMask.SetActive(true);
        isPlayButtonClicked = true;
    }
    public void ClickStethoscopeButton()
    {
        isStethoscopeButtonClicked = true;
        stethoscopeButton.SetActive(false);
    }

    public void ClickOxygenButton()
    {
        isOxygenButtonClicked = true;
        oxygenButton.SetActive(false);
    }
}
