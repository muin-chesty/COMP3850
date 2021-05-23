using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apron : MonoBehaviour
{
    public Transform player;
    private bool isClicked = false;
    [SerializeField]
    private float speed = 10f;
    
    void Update()
    {
        if(isClicked)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        }
    }

    private void OnMouseDown()
    {
        isClicked = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.gameObject.SetActive(false);
    }
}
