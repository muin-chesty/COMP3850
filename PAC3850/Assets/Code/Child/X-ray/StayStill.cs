using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class StayStill : MonoBehaviour
{
    private float timer = 0f;
    [SerializeField]
    private float xRayTime = 10f;
    public Image image;
    [SerializeField]
    private float speed = 0f;

    private float moveTimer = 0f;
    [SerializeField]
    private float addSpeedDelay = 1f;
    private Vector2 initialPosition;

    public GameObject inputCanvas;
    public GameObject xRayCanvas;

    void Start()
    {
        initialPosition = transform.position;
    }
    public void KeepStill()
    {
        speed = 0f;
        transform.Translate(Vector2.zero);
        transform.position = initialPosition;
    }
    // Update is called once per frame
    void Update()
    {
        TakeXRay();
        Vector2 dummy = Vector2.left * (Time.deltaTime * speed);
        transform.Translate(dummy);
        moveTimer += Time.deltaTime;
        if(moveTimer >= addSpeedDelay && image.gameObject.activeSelf == false)
        {
            moveTimer = 0f;
        
            speed = UnityEngine.Random.Range(-2f, 2f);
        }
    }

    private void TakeXRay()
    {
        timer += Time.deltaTime;
        if (timer >= xRayTime)
        {
            image.gameObject.SetActive(true);
            Time.timeScale = 0.3f;
            image.color = new Color(image.color.r, image.color.g, image.color.b, image.color.a - Time.deltaTime);
            if (image.color.a <= 0.2f)
            {
                image.gameObject.SetActive(false);
                Time.timeScale = 1f;
                inputCanvas.SetActive(false);
                transform.gameObject.SetActive(false);
                xRayCanvas.SetActive(true);
            }

        }
    }
}
