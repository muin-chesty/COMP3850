using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMask : MonoBehaviour
{
    private bool hasCollided = false;
    private float timer = 0f;
    private float delay = 5f;
    private SpriteRenderer sprite;
    private bool isMaskTaskCompleted = false;

    [Header("ScriptManager")]
    public UIAnimation ui;
    // -0.88, -0.98
    [Header("Move Stethoscope Script")]
    [Space]
    public StethoscopeMove stMove;
    [Header("Oxygen mask")]
    [Space]
    public GameObject oxygenMask;
    [Header("Face Object")]
    [Space]
    public GameObject face;
    [Header("Text panels")]
    [Space]
    public GameObject oxygenPanel;
    public GameObject fadeOxygenPanel;

    [Header("Child and Parent")]
    [Space]
    public GameObject player;
    public GameObject parent;

    [Header("Stethoscope")]
    [Space]
    public GameObject stethoscope;

    

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    public bool GetMaskTaskCompleted()
    {
        return isMaskTaskCompleted;
    }
    void Update()
    {
        if(hasCollided)
        {
            timer += Time.deltaTime;
            if(timer >= (delay - (delay - 1f)))
            {
                oxygenPanel.SetActive(true);
                sprite.color = new Color(0f,0f,0f,0f);
                parent.SetActive(false);
                if(stethoscope.activeSelf)
                {
                    stethoscope.SetActive(false);
                }
               
                player.SetActive(false);
                if(timer >= delay + 1f)
                {
                    oxygenPanel.SetActive(false);
                    fadeOxygenPanel.SetActive(true);

                    if(timer >= delay + 2.2f)
                    {
                        fadeOxygenPanel.SetActive(false);
                        oxygenMask.SetActive(false);
                        if(!stMove.GetHBCompleted())
                        {
                            stethoscope.SetActive(true);
                        }
                        
                        parent.SetActive(true);
                        player.SetActive(true);
                        isMaskTaskCompleted = true;
                    }
                }
            }
        }

        if (ui.GetOxygenButtonClicked() && (hasCollided == false))
        {
            oxygenMask.transform.position = Vector2.MoveTowards(
                    oxygenMask.transform.position, face.transform.position, 3f * Time.deltaTime
                    );
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.name == "Oxygen Mask" && collision.gameObject.name == "Face")
        {
            collision.gameObject.SetActive(false);
            hasCollided = true;
            
        }
    }
}
