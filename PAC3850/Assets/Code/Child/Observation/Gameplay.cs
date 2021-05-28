using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    public GameObject bloodPressureButton;
    public GameObject temperatureButton;
    public GameObject feelPulseButton;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bloodPressureButton.SetActive(true);
        temperatureButton.SetActive(true);
        feelPulseButton.SetActive(true);
    }
}
