using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GateKeeper : MonoBehaviour
{
    public int numOfItems;
    public static int count = 0;

    public GameObject closingCanvas;

    private float timer = 0f;
 

    // Update is called once per frame
    void Update()
    {
        if(count >= numOfItems)
        {
            closingCanvas.SetActive(true);
            timer += Time.deltaTime;
            if(timer >= 1.5f)
            {
                SceneManager.LoadScene("Receiption");
            }
        }
    }
}
