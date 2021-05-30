using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Observation : MonoBehaviour
{
    public GameObject introText;
    public GameObject downIntroText;
    public GameObject parent;
    public GameObject child;
    public GameObject preMiniGamePanel;
    public GameObject fadestethoscopeGamePanel;
    public GameObject playButton;
    public GameObject chair;

    // -0.99, -1.426
    public ArmCollision arm;
    public ForeheadCollision temp;
    public ObservationCollision wrist;
    private static int count = 0;


    private float introTextTimer = 0f;
    private float introTextDelay = 1f;
    [SerializeField]
    private float introTextDownTimeAnimationDelay = 5f;



    private float sthethoscopeTimer = 0f;
    [SerializeField]
    private float sthethoscopePanelDelay = 5f;

    private bool isPlayClicked = false;
    public GameObject OxygenButton;
    public GameObject peg;

    private float oxgButtonTimer = 0f;
    private float oxgButtonDelay = 5f;



    public Gameplay childScript;
    public static void AddToCount()
    {
        count++;
    }

    public void Play()
    {
        isPlayClicked = true;
        playButton.SetActive(false);
    }

    void Update()
    {

        if((childScript.GetOxygenClicked() == false) && arm.isBPChecked && wrist.isPulseFelt && temp.isTempChecked)
        {
            oxgButtonTimer += Time.deltaTime;
            if(oxgButtonTimer >= oxgButtonDelay)
            {
                OxygenButton.SetActive(true);
                count = 0;
                peg.SetActive(true);
            }
           
        }
        if(isPlayClicked)
        {   if(chair != null)
            {
                child.transform.position =
               Vector3.MoveTowards(child.transform.position, chair.transform.position, 3f * Time.deltaTime);
            }
           
        }
        introTextTimer += Time.deltaTime;
        if (introTextTimer >= introTextDelay)
        {
            introText.SetActive(false);
            downIntroText.SetActive(true);
        }
        if (introTextTimer >= (introTextDelay + introTextDownTimeAnimationDelay))
        {
            downIntroText.SetActive(false);
            
            if(!isPlayClicked)
            {
                playButton.SetActive(true);
            }
            if(playButton.activeSelf == true)
            {
                parent.SetActive(true);
                child.SetActive(true);
            }
           
        }

/*        if (preMiniGamePanel.activeSelf == true)
        {
            sthethoscopeTimer += Time.deltaTime;
            if (sthethoscopeTimer >= sthethoscopePanelDelay)
            {
                preMiniGamePanel.SetActive(false);
                fadestethoscopeGamePanel.SetActive(true);
                if (sthethoscopeTimer >= (sthethoscopePanelDelay + 1))
                {
                    fadestethoscopeGamePanel.SetActive(false);
                    
                }
            }
        }*/
    }
}
