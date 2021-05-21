using UnityEngine;
using UnityEngine.SceneManagement;

public class Tests : MonoBehaviour
{
    public GameObject echoPanel;
    public GameObject ecgPanel;
    public GameObject chestPanel;
    public GameObject bloodPanel;
    public GameObject weightAndHeightPanel;
    public GameObject observationPanel;
    public GameObject infectionPanel;
    public GameObject closingCanvas;

    private float timer = 0.0f;
    [SerializeField]
    private float delay = 1.0f;
    private bool isBackButtonClicked = false;
    void Start()
    {
        echoPanel.SetActive(false);
        ecgPanel.SetActive(false);
        chestPanel.SetActive(false);
        bloodPanel.SetActive(false);
        weightAndHeightPanel.SetActive(false);
        observationPanel.SetActive(false);
        infectionPanel.SetActive(false);
        closingCanvas.SetActive(false);
    }

    public void LoadPACDay()
    {
        isBackButtonClicked = true;
        closingCanvas.SetActive(true);
    }
    public void ActivateECGPanel()
    {
        ecgPanel.SetActive(true);
    }

    public void DeactivateECGPanel()
    {
        ecgPanel.SetActive(false);
    }
    public void ActivateECHOPanel()
    {
        echoPanel.SetActive(true);
    }

    public void DeactivateECHOPanel()
    {
        echoPanel.SetActive(false);
    }
    public void ActivateChestPanel()
    {
        chestPanel.SetActive(true);
    }

    public void DeactivateChestPanel()
    {
        chestPanel.SetActive(false);
    }
    public void ActivateBloodPanel()
    {
        bloodPanel.SetActive(true);
    }
    public void DeactivateBloodPanel()
    {
        bloodPanel.SetActive(false);
    }
    public void ActivateWeightAndHeightPanel()
    {
        weightAndHeightPanel.SetActive(true);
    }

    public void DeactivateWeightAndHeightPanel()
    {
        weightAndHeightPanel.SetActive(false);
    }

    public void ActivateObservationPanel()
    {
        observationPanel.SetActive(true);
    }

    public void DeactivateObservationPanel()
    {
        observationPanel.SetActive(false);
    }

    public void ActivateInfectionPanel()
    {
        infectionPanel.SetActive(true);
    }

    public void DeactivateInfectionPanel()
    {
        infectionPanel.SetActive(false);
    }
    void Update()
    {
        if (isBackButtonClicked)
        {
            timer += Time.deltaTime;
            if (timer >= delay)
            {
                timer = 0f;
                SceneManager.LoadScene("PACDay");
            }
        }

    }
}
