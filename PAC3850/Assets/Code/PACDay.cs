using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PACDay : MonoBehaviour
{
    public GameObject meetingNursePanel;
    public GameObject medicalAssessmentPanel;
    public GameObject anaestheticReviewPanel;
    public GameObject researchPanel;
    public GameObject sickChildPanel;
    public GameObject closingCanvas;

    private float timer = 0.0f;
    [SerializeField]
    private float delay = 1.0f;
    private bool isBackButtonClicked = false;
    private bool isTestsButtonClicked = false;
    void Start()
    {
        meetingNursePanel.SetActive(false);
        medicalAssessmentPanel.SetActive(false);
        anaestheticReviewPanel.SetActive(false);
        researchPanel.SetActive(false);
        sickChildPanel.SetActive(false);
        closingCanvas.SetActive(false);
    }

    public void LoadGettingReady()
    {
        isBackButtonClicked = true;
        closingCanvas.SetActive(true);
    }
    public void ActivateSickChildPanel()
    {
        sickChildPanel.SetActive(true);
    }

    public void DeactivateSickChildPanel()
    {
        sickChildPanel.SetActive(false);
    }
    public void ActivateResearchPanel()
    {
        researchPanel.SetActive(true);
    }

    public void DeactivateResearchPanel()
    {
        researchPanel.SetActive(false);
    }
    public void ActivateAnaestheticReviewPanel()
    {
        anaestheticReviewPanel.SetActive(true);
    }

    public void DeactivateAnaestheticReviewPanel()
    {
        anaestheticReviewPanel.SetActive(false);
    }
    public void ActivateMedicalAssessment()
    {
        medicalAssessmentPanel.SetActive(true);
    }
    public void DeactivateMedicalAssessment()
    {
        medicalAssessmentPanel.SetActive(false);
    }
    public void ActivateMeetingNursePanel()
    {
        meetingNursePanel.SetActive(true);
    }

    public void DeactivateMeetingNursePanel()
    {
        meetingNursePanel.SetActive(false);
    }
    public void LoadTests()
    {
        isTestsButtonClicked = true;
        closingCanvas.SetActive(true);
    }
    void Update()
    {
        if(isBackButtonClicked)
        {
            timer += Time.deltaTime;
            if (timer >= delay)
            {
                timer = 0f;
                SceneManager.LoadScene("GettingReady");
            }
        }
        if(isTestsButtonClicked)
        {
            timer += Time.deltaTime;
            if(timer >= delay)
            {
                timer = 0f;
                SceneManager.LoadScene("Tests");
            }
        }
        
    }
}
