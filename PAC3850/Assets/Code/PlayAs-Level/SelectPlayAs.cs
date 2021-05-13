using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectPlayAs : MonoBehaviour
{
    [SerializeField]
    UnityEngine.UI.Text playAs;
    [SerializeField]
    GameObject outroObject;
    [SerializeField]
    GameObject animationObject;

    private float initTimer = 0.0f;
    private float initDelay = 0.5f;
    private float timer = 0.0f;
    [SerializeField]
    private float pause = 0.1f;
    private int index = 0;
    private char[] text = { 'P', 'L', 'A', 'Y', ' ', 'A', 'S' };

    private bool isButtonClicked = false;
    private float levelTimer = 0.0f;
    private float levelDelay = 1f;
    private string levelName = "";
    private float animationTimer = 0.0f;
    [SerializeField]
    private float animationDelay = 1f;

    private void Start()
    {
        outroObject.SetActive(false);
        animationObject.SetActive(false);
    }
    private void Update()
    {
        if(isButtonClicked)
        {
            animationObject.SetActive(false);
            levelTimer += Time.deltaTime;
            outroObject.SetActive(true);
            if(levelTimer >= levelDelay)
            {
                SceneManager.LoadScene(levelName);
            }
        }
        initTimer += Time.deltaTime;
        if(initTimer >= initDelay)
        {
            timer += Time.deltaTime;
            if (timer >= pause)
            {
                timer = 0.0f;
                if (index < text.Length)
                {
                    playAs.text += text[index++];
                }
              

            }
        }
        animationTimer += Time.deltaTime;
        if(animationTimer >= animationDelay)
        {
             animationObject.SetActive(true);
        }

    }
    public void LoadChildSection()
    {
        isButtonClicked = true;
        levelName = "ChildInfo";
        animationObject.SetActive(false);
    }

    public void LoadParentSection()
    {
        isButtonClicked = true;
        levelName = "ParentInfo";
        animationObject.SetActive(false);
    }
}
