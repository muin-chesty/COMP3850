using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeOutfit : MonoBehaviour
{
    public List<Sprite> sprites;
    private SpriteRenderer renderer;
    private Animator anim;
    private float timer = 0f;
    private bool hasChanged = false;
    
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hasChanged)
        {
            timer += Time.deltaTime;
            if(timer >= 1f)
            {
                SceneManager.LoadScene("3-X-Ray");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        anim.enabled = false;
        hasChanged = true;
        renderer.sprite = sprites[0];
    }
}
