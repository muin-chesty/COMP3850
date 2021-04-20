using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public GameObject VFXCollect;
    public AudioSource audioSource;
    public AudioClip sfx;
    public float sfxVolume;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(VFXCollect, transform);
        Destroy(collision.gameObject);
        audioSource.PlayOneShot(sfx,sfxVolume);
    }
}
