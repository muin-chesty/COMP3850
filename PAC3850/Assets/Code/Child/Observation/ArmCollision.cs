
//using System.Diagnostics;
using UnityEngine;

public class ArmCollision : MonoBehaviour
{
    public GameObject bloodPressurePanel;
    public GameObject fadeBloodPressurePanel;

    public GameObject player;
    public GameObject parent;
    public GameObject temperatureGun;
    public GameObject firstHand;
    public ObservationCollision observation;
    public ForeheadCollision temp;
    public bool isBPChecked = false;

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
                bloodPressurePanel.SetActive(false);
                fadeBloodPressurePanel.SetActive(true);

                if (timer >= delay + 1.2f) // TO REMOVE THE FADE PANEL AFTER IT DISAPPEARS
                {
                    hasCollided = false;
                    fadeBloodPressurePanel.SetActive(false);
                    ActivateButtons();
                    
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
        firstHand.SetActive(false);
    }

    private void ActivateButtons()
    {
        player.SetActive(true);
        parent.SetActive(true);
        
        if(!observation.isPulseFelt)
        {
            firstHand.SetActive(true);
        }
        if(!temp.isTempChecked)
        {
            temperatureGun.SetActive(true);
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "Second Hand" && gameObject.name == "Arm")
        {
            collision.gameObject.SetActive(false);
            bloodPressurePanel.SetActive(true);
            DeactivateButtons();
            hasCollided = true;
            isBPChecked = true;
        }



    }
}
