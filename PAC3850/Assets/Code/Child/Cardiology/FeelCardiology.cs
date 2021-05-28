using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FeelCardiology : MonoBehaviour
{
    public GameObject chest;
    public GameObject stethoscope;
    [Space]
    public GameObject hand;
    public GameObject feet;
    public GameObject fingers;
    public GameObject tummy;
    

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
    }
    public void FeetButton()
    {
        isFeetClicked = true;
    }
    public void FingersButton()
    {
        isHandClicked = true;
    }
    public void TummyButton()
    {
        isTummyClicked = true;
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
            SceneManager.LoadScene("PlayAs");
        }

        if(isChestClicked)
        {
            
            stethoscope.transform.position = Vector2.MoveTowards(stethoscope.transform.position,chest.transform.position, speed * Time.deltaTime);
        }

        if(isFeetClicked)
        {
       
            hand.transform.position = Vector2.MoveTowards(hand.transform.position, feet.transform.position, speed * Time.deltaTime);
        }
        if (isHandClicked)
        {
           
            hand.transform.position = Vector2.MoveTowards(hand.transform.position, fingers.transform.position, speed * Time.deltaTime);
        }
        if (isTummyClicked)
        {
           
            hand.transform.position = Vector2.MoveTowards(hand.transform.position, tummy.transform.position, speed * Time.deltaTime);
        }
    }
}
