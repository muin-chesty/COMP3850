using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private bool hasCollided = false;

    [Header("Script Manager")]
    public UIAnimation ui;
    [Space]
    [Header("Child and Chair")]
    public GameObject player;
    public GameObject chair;
    [Space]
    [Header("Oxygen Button and Stethoscope Button")]
    public GameObject oxygenButton;
    public GameObject stethoscopeButton;
    


   
    void Update()
    {
        if(ui.GetPlayButtonClicked() && (hasCollided == false) )
        {
            player.transform.position = Vector2.MoveTowards(
                player.transform.position, chair.transform.position, 3f * Time.deltaTime
                );
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(gameObject.name == "Child" && collision.gameObject.name == "Chair")
        {
            collision.gameObject.SetActive(false);
            hasCollided = true;
            stethoscopeButton.SetActive(true);
            oxygenButton.SetActive(true);
        }
    }
}
