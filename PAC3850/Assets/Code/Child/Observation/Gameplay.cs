using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    public GameObject bloodPressureButton;
    public GameObject temperatureButton;
    public GameObject feelPulseButton;
    public GameObject oxygenButton;

    [Space]
    public GameObject handIcon;
    public GameObject secondHand;
    public GameObject temperatureGun;
    public GameObject peg;
    [Space]
    public GameObject wrist;
    public GameObject arm;
    public GameObject forehead;
    public GameObject finger;

    private bool isPulseButtonClicked = false;
    private bool isBloodPressureButtonClicked = false;
    private bool isTempreatureClicked = false;
    private bool isOxygenClicked = false;


    public bool GetOxygenClicked()
    {
        return isOxygenClicked;
    }

    void Update()
    {
        if(isPulseButtonClicked)
        {
            if (wrist != null && handIcon != null)
            {
                handIcon.transform.position =
               Vector2.MoveTowards(handIcon.transform.position,
               wrist.transform.position,
               3f * Time.deltaTime);
            }
           
        }

        if (isBloodPressureButtonClicked)
        {
            if (arm != null && secondHand != null)
            {
                secondHand.transform.position =
               Vector2.MoveTowards(secondHand.transform.position,
               arm.transform.position,
               3f * Time.deltaTime);
            }

        }

        if (isTempreatureClicked)
        {
            if (forehead != null && temperatureGun != null)
            {
                temperatureGun.transform.position =
               Vector2.MoveTowards(temperatureGun.transform.position,
               forehead.transform.position,
               3f * Time.deltaTime);
            }

        }
        if (isOxygenClicked)
        {
            if (finger != null && peg != null)
            {
                peg.transform.position =
               Vector2.MoveTowards(peg.transform.position,
               finger.transform.position,
               3f * Time.deltaTime);
            }

        }
    }

    public void OxygenButtonClick()
    {
        oxygenButton.SetActive(false);
        isOxygenClicked = true;
    }
    public void FeelPulse()
    {
        feelPulseButton.SetActive(false);
        isPulseButtonClicked = true;
        secondHand.SetActive(true);
    }
    public void Temperature()
    {
        isTempreatureClicked = true;
        temperatureButton.SetActive(false);

    }
    public void BloodPressure()
    {
        bloodPressureButton.SetActive(false);
        isBloodPressureButtonClicked = true;
        handIcon.SetActive(true);
        secondHand.SetActive(true);
    }


    // ONLY FOR THE PLAYER TO GO TO THE CHAIR
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.name == "Chair")
        {
            Destroy(collision.gameObject);
            bloodPressureButton.SetActive(true);
            temperatureButton.SetActive(true);
            feelPulseButton.SetActive(true);


            handIcon.SetActive(true);
            temperatureGun.SetActive(true);
        }
       

    }
}
