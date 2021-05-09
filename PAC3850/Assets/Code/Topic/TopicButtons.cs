using UnityEngine.SceneManagement;
using UnityEngine;

public class TopicButtons : MonoBehaviour
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
        levelName = "FAQ";
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
