using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InitCustomisationLevel : MonoBehaviour
{
    public GameObject closingTransition;
    public float startsIn = 1f;
    private float timer;
    private bool isClicked = false;

    public InputField firstName;
    public InputField lastName;
    public InputField parentName;
    public InputField DOB;
    public InputField id;
    
    private void Update()
    {
        if(isClicked)
        {
            closingTransition.SetActive(true);
            timer += Time.deltaTime;
            if (timer >= startsIn)
            {
                timer = 0f;
                SceneManager.LoadScene("Level 1-Packing");
                isClicked = false;
            }
        }

    }
    public void LoadCustomisationLevel()
    {
        isClicked = true;

        Child.first_name = firstName.text;
        Child.last_name = lastName.text;
        Child.id = id.text;
        Child.parent = parentName.text;
        Child.dob = DOB.text;
        
    }
}
