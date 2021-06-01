using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FeelCardiology : MonoBehaviour
{
   
   
    [Space]
    [Header("Body Objects")]
    public GameObject feet;
    public GameObject fingers;
    public GameObject tummy;
    public GameObject chest;
    public GameObject stethoscope;

    [Space]
    [Header("hands")]
    public GameObject hand;
    public GameObject handTwo;
    public GameObject handThree;
    public float speed;

    public static Vector3 STETHOSCOPE_INIT_POS;
    public static Vector3 HAND_INIT_POS;

    private bool isChestClicked = false;

    private bool isFeetClicked = false;
    private bool isHandClicked = false;
    private bool isTummyClicked = false;

    private bool chestChecked = false;
    private bool handChecked = false;
    private bool feetChecked = false;
    private bool tummyChecked = false;

    [Header("Buttons")]
    [Space]
    public GameObject tummyButton;
    public GameObject feetButton;
    public GameObject handButton;
    public GameObject chestButton;

    [Header("Feedback Canvas")]
    [Space]
    public GameObject feedbackCanvas;

    void Start()
    {
        STETHOSCOPE_INIT_POS = stethoscope.transform.position;
        HAND_INIT_POS = hand.transform.position;
    }

    public void FeelCollisionCompleted()
    {
        isHandClicked = false;
        isFeetClicked = false;
        isTummyClicked = false;
    }
    public void ChestCollisionCompleted()
    {
        isChestClicked = false;
    }


    public void ChestButton()
    {
        isChestClicked = true;
        chestButton.SetActive(false);
    }
    public void FeetButton()
    {
        isFeetClicked = true;
        feetButton.SetActive(false);
    }
    public void FingersButton()
    {
        isHandClicked = true;
        handButton.SetActive(false);
    }
    public void TummyButton()
    {
        isTummyClicked = true;
        tummyButton.SetActive(false);
    }

    public void HandChecked()
    {
        handChecked = true;
    }

    public void TummyChecked()
    {
        tummyChecked = true;
    }

    public void FeetChecked()
    {
        feetChecked = true;
    }

    public void ChestChecked()
    {
        chestChecked = true;
    }
    void Update()
    {
        if(chestChecked && feetChecked && handChecked && tummyChecked)
        {
            // ACTIVATE FEEDBACK CANVAS
            feedbackCanvas.SetActive(true);
           
        }

        if(isChestClicked)
        {
            
            stethoscope.transform.position = Vector2.MoveTowards(stethoscope.transform.position,chest.transform.position, speed * Time.deltaTime);
        }

        if(isFeetClicked)
        {
       
            handTwo.transform.position = Vector2.MoveTowards(handTwo.transform.position, feet.transform.position, speed * Time.deltaTime);
        }
        if (isHandClicked)
        {
           
            hand.transform.position = Vector2.MoveTowards(hand.transform.position, fingers.transform.position, speed * Time.deltaTime);
        }
        if (isTummyClicked)
        {
           
            handThree.transform.position = Vector2.MoveTowards(handThree.transform.position, tummy.transform.position, speed * Time.deltaTime);
        }
    }
}
