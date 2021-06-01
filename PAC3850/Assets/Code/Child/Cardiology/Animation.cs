using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Animation : MonoBehaviour
{
    public GameObject introText;
    public GameObject downIntroText;
    public GameObject parent;
    public GameObject child;
    public GameObject sthethoscopeGamePanel;
    public GameObject fadestethoscopeGamePanel;
    public GameObject playButton;
    public GameObject player;
    public GameObject stethoscopeObject;
    public GameObject handObject;
   

    private float introTextTimer = 0f;
    private float introTextDelay = 1f;
    [SerializeField]
    private float introTextDownTimeAnimationDelay = 5f;
    


    private float sthethoscopeTimer = 0f;
    [SerializeField]
    private float sthethoscopePanelDelay = 5f;

    [Space]
    [Header("Closing Canvas")]
    public GameObject closingCanvas;
    private float closingCanvasTimer = 0f;
    private readonly float closingCanvasDelay = 1.5f;
    private bool isPlayClicked = false; 

    void Start()
    {
        
    }
    public void Play()
    {
        
        isPlayClicked = true;
    }
   
    void Update()
    {
        if(isPlayClicked)
        {
            closingCanvas.SetActive(true);
            closingCanvasTimer += Time.deltaTime;
            if(closingCanvasTimer >=  closingCanvasDelay)
            {
                SceneManager.LoadScene("2-Cardiology");
                isPlayClicked = false; // RESET FOR NOTHING 
            }
           
        }

        introTextTimer += Time.deltaTime; 
        if(introTextTimer >= introTextDelay)
        {
            introText.SetActive(false);
            downIntroText.SetActive(true);
        }
        if(introTextTimer >= ( introTextDelay + introTextDownTimeAnimationDelay) )
        {
            downIntroText.SetActive(false);
            parent.SetActive(true);
            child.SetActive(true);
            sthethoscopeGamePanel.SetActive(true);
        }

        if(sthethoscopeGamePanel.activeSelf == true)
        {
            sthethoscopeTimer += Time.deltaTime;
            if(sthethoscopeTimer >= sthethoscopePanelDelay)
            {
                sthethoscopeGamePanel.SetActive(false);
                fadestethoscopeGamePanel.SetActive(true);
                if(sthethoscopeTimer >=  (sthethoscopePanelDelay + 1) )
                {
                    fadestethoscopeGamePanel.SetActive(false);
                    playButton.SetActive(true);
                }
            }
        }
    }
}
