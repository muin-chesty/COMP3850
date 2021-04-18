using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsBagpack : MonoBehaviour
{
    [SerializeField]
    private GameObject target;
    [SerializeField]
    [Tooltip("The speed at which item will move towards backpack")]
    private float speed;
    private Vector2 targetPos;
    private bool isClicked = false;

    void Start()
    {
        targetPos = target.transform.position;
    }

    private void OnMouseDown()
    {
        isClicked = true;
    }

    private void Update()
    {
        if(isClicked)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPos, Time.deltaTime * speed);
        }
    }
}
