using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSelectMajor : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ClickTarget();
        }
    }

    private void ClickTarget()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), -Vector2.up);
        if (hit.collider != null)
        {
          
            this.GetComponent<AllInvisible>().callToInvisible();
            hit.collider.gameObject.GetComponent<ChildManager>().ChildToRend.enabled = true;

        }  
        
    }
}
