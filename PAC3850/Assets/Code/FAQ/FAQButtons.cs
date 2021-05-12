
using UnityEngine;
using UnityEngine.SceneManagement;

public class FAQButtons : MonoBehaviour
{
    private bool isLevelComplete = false;
    private float timer = 0.0f;
    [SerializeField]
    private float delay = 1f;
    [SerializeField]
    private GameObject outroCanvas;
    private string levelName = "";
   
    void Start()
    {
        outroCanvas.SetActive(false);
    }

    public void GoBack()
    {
        isLevelComplete = true;
        levelName = "ParentMenu";
    }
    public void One()
    {
        isLevelComplete = true;
        levelName = "One";
    }
    public void Two()
    {
        isLevelComplete = true;
        levelName = "Two";
    }
    void Update()
    {
        if (isLevelComplete)
        {
            timer += Time.deltaTime;
            outroCanvas.SetActive(true);
            if (timer >= delay)
            {
                SceneManager.LoadScene(levelName);
            }
        }
    }
}
