using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeheadCollision : MonoBehaviour
{
    public GameObject temperaturePanel;
    public GameObject fadetemperaturePanel;

    public GameObject player;
    public GameObject parent;
    public GameObject temperatureGun;
    public GameObject secondHand;
    public GameObject firstHand;
    public bool isTempChecked = false;

    public ArmCollision arm;
    public ObservationCollision observation;
    
    private float timer = 0f;
    private float delay = 5f;
    private bool hasCollided = false;

    private void Update()
    {
        if (hasCollided == true)
        {

            timer += Time.deltaTime;
            if (timer >= delay)
            {
                temperaturePanel.SetActive(false);
                fadetemperaturePanel.SetActive(true);

                if (timer >= delay + 1.2f) // TO REMOVE THE FADE PANEL AFTER IT DISAPPEARS
                {
                    fadetemperaturePanel.SetActive(false);
                    ActivateButtons();
                    hasCollided = false;
                    Observation.AddToCount();
                    
                }
            }
        }

    }
    private void DeactivateButtons()
    {
        player.SetActive(false);
        parent.SetActive(false);
        temperatureGun.SetActive(false);
        if(firstHand.activeSelf)
        {
            firstHand.SetActive(false);
        }
        if(secondHand.activeSelf)
        {
            secondHand.SetActive(false);
        }
    }

    private void ActivateButtons()
    {
        player.SetActive(true);
        parent.SetActive(true);
        if(!arm.isBPChecked)
        {
            secondHand.SetActive(true);
        }
        if(!observation.isPulseFelt)
        {
            firstHand.SetActive(true);
        }
        


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "Temperature Gun" && gameObject.name == "Forehead")
        {
            collision.gameObject.SetActive(false);
            temperaturePanel.SetActive(true);
            // DEACTIVATE BUTTONS
            DeactivateButtons();
            hasCollided = true;
            isTempChecked = true;
        }



    }
}
