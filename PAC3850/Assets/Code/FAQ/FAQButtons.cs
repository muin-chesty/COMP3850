
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

    [Space]
    public GameObject bringPanel;
    public GameObject tellChildPanel;
    public GameObject accompanyingParentPanel;
    public GameObject addressPanel;
    public GameObject supportPanel;
    public GameObject sickChildPanel;

    void Start()
    {
        outroCanvas.SetActive(false);
        bringPanel.SetActive(false);
        tellChildPanel.SetActive(false);
        accompanyingParentPanel.SetActive(false);
        addressPanel.SetActive(false);
        supportPanel.SetActive(false);
        sickChildPanel.SetActive(false);
    }

    public void ActivateSickChildPanel()
    {
        sickChildPanel.SetActive(true);
    }

    public void DeactivateSickChildPanel()
    {
        sickChildPanel.SetActive(false);
    }
    public void ActivateSupportPanel()
    {
        supportPanel.SetActive(true);
    }
    public void DisableSupportPanel()
    {
        supportPanel.SetActive(false);
    }

    public void ActivateBringPanel()
    {
        bringPanel.SetActive(true);
    }
    public void DisableBringPanel()
    {
        bringPanel.SetActive(false);
    }

    public void ActivateAddressPanel()
    {
        addressPanel.SetActive(true);
    }
    public void DisableAddressPanel()
    {
       addressPanel.SetActive(false);
    }

    public void ActivateAccompanyingParentPanel()
    {
        accompanyingParentPanel.SetActive(true);
    }
    public void DisableAccompanyingParentPanel()
    {
        accompanyingParentPanel.SetActive(false);
    }

    public void ActivateTellChildPanel()
    {
        tellChildPanel.SetActive(true);
    }
    public void DisableTellChildPanel()
    {
        tellChildPanel.SetActive(false);
    }

    public void PACDay()
    {
        isLevelComplete = true;
        levelName = "PACDay";
    }
    public void GoBack()
    {
        isLevelComplete = true;
        levelName = "Paths";
    }
    public void One()
    {
        isLevelComplete = true;
        levelName = "One";
    }
    public void LoadGettingReady()
    {
        isLevelComplete = true;
        levelName = "GettingReady";
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
