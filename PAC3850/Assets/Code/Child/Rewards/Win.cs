using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject winPanel;
    public void Submit()
    {
        winPanel.SetActive(true);
    }
}
