
using UnityEngine;

public class FingerCollision : MonoBehaviour
{

    public GameObject oxygenPanel;
    public GameObject fadeOxygenPanel;
    [Space]
    public GameObject child;
    public GameObject parent;
    [Space]
    public GameObject upHBPanel;
    public GameObject downHBPanel;
    private bool hasCollided = false;
    private float timer = 0f;
    private float delay = 5f;

    public bool oxygenSaturationCompleted = false;
    private bool bringUpHBPanel = false;
    private void Update()
    {
        if (hasCollided == true)
        {

            timer += Time.deltaTime;
            if (timer >= delay)
            {
                oxygenPanel.SetActive(false);
                fadeOxygenPanel.SetActive(true);

                if (timer >= delay + 1.2f) // TO REMOVE THE FADE PANEL AFTER IT DISAPPEARS
                {
                    fadeOxygenPanel.SetActive(false);
                   
                    hasCollided = false;
                   
                    child.SetActive(true);
                    parent.SetActive(true);
                    bringUpHBPanel = true;
                    upHBPanel.SetActive(true);
                    timer = 0f;
                   
                }
            }
        }
        if(bringUpHBPanel)
        {
            timer += Time.deltaTime;
            if(timer >= delay)
            {
                upHBPanel.SetActive(false);
                downHBPanel.SetActive(true);
                if(timer >= delay + 12f)
                {
                    downHBPanel.SetActive(false);
                    bringUpHBPanel = false;
                    oxygenSaturationCompleted = true;
                    timer = 0f;
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Peg" && gameObject.name == "Finger")
        {
            collision.gameObject.SetActive(false);
            hasCollided = true;
            oxygenPanel.SetActive(true);
            parent.SetActive(false);
            child.SetActive(false);
        }
    }
}
