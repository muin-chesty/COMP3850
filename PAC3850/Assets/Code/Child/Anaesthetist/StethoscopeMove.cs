using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StethoscopeMove : MonoBehaviour
{
    private bool hasCollided = false;
    private float timer = 0f;
    private float delay = 5f;
    private SpriteRenderer sprite;
    private bool isHBCompleted = false;

    [Header("ScriptManager")]
    public UIAnimation ui;

    [Header("Move Mask Script")]
    [Space]
    public MoveMask mask;
    // face:  -0.88, -1.084
    // heart: -0.88, -1.38
    [Header("Oxygen mask")]
    [Space]
    public GameObject oxygenMask;
    [Header("Heart Object")]
    [Space]
    public GameObject heart;
    [Header("Text panels")]
    [Space]
    public GameObject stethoscopePanel;
    public GameObject fadeStethoscopePanel;

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

    public bool GetHBCompleted()
    {
        return isHBCompleted;
    }
    void Update()
    {
        if (hasCollided)
        {
           
            timer += Time.deltaTime;
            if (timer >= (delay - (delay - 1f)))
            {
                stethoscopePanel.SetActive(true);
                sprite.color = new Color(0f, 0f, 0f, 0f);
                parent.SetActive(false);
                player.SetActive(false);
                if (oxygenMask.activeSelf)
                {
                    oxygenMask.SetActive(false);
                }

               
                if (timer >= delay + 1f)
                {
                    stethoscopePanel.SetActive(false);
                    fadeStethoscopePanel.SetActive(true);

                    if (timer >= delay + 2.2f)
                    {
                        fadeStethoscopePanel.SetActive(false);
                        stethoscope.SetActive(false);
                        // CHECK IF MASK IS COMPLETED OR NOT
                        if(!mask.GetMaskTaskCompleted())
                        {
                            oxygenMask.SetActive(true);
                        }
                       
                        parent.SetActive(true);
                        player.SetActive(true);
                        isHBCompleted = true;
                    }
                }
            }
        }

        if (ui.GetStethoscopeButtonClicked() && (hasCollided == false))
        {
            stethoscope.transform.position = Vector2.MoveTowards(
                    stethoscope.transform.position, heart.transform.position, 3f * Time.deltaTime
                    );
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.name == "Stethoscope" && collision.gameObject.name == "Heart")
        {
            Debug.Log(hasCollided);
            collision.gameObject.SetActive(false);
            hasCollided = true;

        }
    }
}
