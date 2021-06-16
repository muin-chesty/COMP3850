using UnityEngine.Networking;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ask : MonoBehaviour
{
    [SerializeField]
    private InputField question;
    private bool isQuestionSubmitted = false;
    private bool backButtonClicked = false;
    private float timer = 0f;

    [SerializeField]
    private float delay = 10f;
    [SerializeField]
    private float backbuttonDelay = 2f;

    [SerializeField]
    private GameObject popupCanvas;
    [SerializeField]
    private GameObject outroCanvas;

    private ParentObject parent;
    void Start()
    {
        popupCanvas.SetActive(false);
        outroCanvas.SetActive(false);
    }
    IEnumerator Upload()
    {
        string api = "https://comp-3850-demo-server.herokuapp.com/api/parents/add";


        string json = JsonUtility.ToJson(parent);
        UnityWebRequest www = UnityWebRequest.Post(api, json);
        //  www.SetRequestHeader("Content-Type", "application/json");
        www.SetRequestHeader("Accept", "application/json");
        www.uploadHandler.contentType = "application/json";
        byte[] bytes = System.Text.Encoding.UTF8.GetBytes(json);
        UploadHandlerRaw uH = new UploadHandlerRaw(bytes);
        www.uploadHandler = uH;
        www.SetRequestHeader("Content-Type", "application/json");
        yield return www.SendWebRequest();

        if (www.isHttpError || www.isNetworkError)
        {
            Debug.Log(www.error);
            Debug.Log(www.downloadHandler.text);


        }


    }

    void Update()
    {
        if (isQuestionSubmitted)
        {
            timer += Time.deltaTime;
            if(timer >= (delay - 1f))
            {
                outroCanvas.SetActive(true);
            }
            if(timer >=  delay)
            {
                SceneManager.LoadScene("Paths");
                isQuestionSubmitted = false;
                timer = 0f;
            }
        }

        if(backButtonClicked)
        {
            timer += Time.deltaTime;
            if(timer >= backbuttonDelay)
            {
                timer = 0f;
                backButtonClicked = false;
                SceneManager.LoadScene("Paths");
            }
        }
    }
    public void BackButton()
    {
        backButtonClicked = true;
        outroCanvas.SetActive(true);
    }
    public void SubmitQuestion()
    {
        parent = new ParentObject();
        parent.name = Parent.name ;
        parent.id = Parent.id;
        parent.question = Parent.question + question.text;
        isQuestionSubmitted = true;
        popupCanvas.SetActive(true);
        StartCoroutine(Upload());
    }
}
