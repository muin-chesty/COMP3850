using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectItem : MonoBehaviour
{
    public GameObject VFXCollect;
    public AudioSource audioSource;
    public AudioClip sfx;
    public float sfxVolume;
    private int collisionCounter = 0;
    public int numberOfItems = 3;
    private bool levelComplete = false;
    private float timer = 0f;
    public float delay = 1;
    private void Start()
    {
       // audioSource.Play();
    }

    private void Update()
    {
        if(levelComplete)
        {
            timer += Time.deltaTime;
            if(timer >= delay)
            {
                SceneManager.LoadScene("Receiption");
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collisionCounter++;
        Instantiate(VFXCollect, transform);
        Destroy(collision.gameObject);
        audioSource.PlayOneShot(sfx,sfxVolume);
        if(collisionCounter >= numberOfItems)
        {
            collisionCounter = 0;
            levelComplete = true;
            
        }

    }
}
