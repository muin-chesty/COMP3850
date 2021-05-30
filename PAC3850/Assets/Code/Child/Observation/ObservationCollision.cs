using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObservationCollision : MonoBehaviour
{
    public GameObject feelPulsePanel;
    public GameObject fadeFeelPulsePanel;

    public GameObject player;
    public GameObject parent;
    public GameObject temperatureGun;
    public GameObject secondHand;
    public ArmCollision arm;
    public ForeheadCollision temp;

    private float timer = 0f;
    private float delay = 5f;
    private bool hasCollided = false;
    public bool isPulseFelt = false;

    private void Update()
    {
        if(hasCollided == true)
        {
            
            timer += Time.deltaTime;
            if (timer >= delay)
            {
                feelPulsePanel.SetActive(false);
                fadeFeelPulsePanel.SetActive(true);

                if (timer >= delay + 1.2f) // TO REMOVE THE FADE PANEL AFTER IT DISAPPEARS
                {
                    fadeFeelPulsePanel.SetActive(false);
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
        secondHand.SetActive(false);
    }

    private void ActivateButtons()
    {
        player.SetActive(true);
        parent.SetActive(true);
        if(!temp.isTempChecked)
        {
            temperatureGun.SetActive(true);
        }
        if(!arm.isBPChecked)
        {
            secondHand.SetActive(true);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Hand" && gameObject.name == "Wrist") 
        {
            collision.gameObject.SetActive(false);
            feelPulsePanel.SetActive(true);
            DeactivateButtons();
            hasCollided = true;
            isPulseFelt = true;
        }




    }
}
