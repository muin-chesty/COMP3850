using UnityEngine.Networking;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FeedbackData : MonoBehaviour
{

    private float timer = 0f;
    private readonly float transitionalEffectDelay = 1.5f;
    private bool isButtonClicked = false;

    private string emotionalResponseData;

    [Header("Current Level name for hospital staff to make sense of")]
    [Tooltip("Write the name of the current level")]
    public string screenName;

    [Space]
    [Header("Closing Canvas")]
    [Tooltip("Drag the disabled closing canvas so it can load once feedback is collected")]
    public GameObject closingCanvas;


    [Space]
    [Header("Name of next level")]
    [Tooltip("Drag the name of the level game will go to once gameplay is completed")]
    public string nameOfLevelToGoTo;
    GameData game;
    void Start()
    {
      
    }

    IEnumerator Upload()
    {
        string api = "https://comp-3850-demo-server.herokuapp.com/api/gameData/add";


        string json = JsonUtility.ToJson(game);
        Debug.Log(json);
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
        else
        {

        }

    }
    public void Relaxed()
    {
        emotionalResponseData = "Relaxed";
        isButtonClicked = true;

        game = new GameData();
        game.feedBack = emotionalResponseData;
        game.patienceID = Child.id;
        game.screenName = screenName;
        
       
        StartCoroutine(Upload());

    }
    public void Stressed()
    {
        emotionalResponseData = "Stressed";
        isButtonClicked = true;

        game = new GameData();
        game.feedBack = emotionalResponseData;
        game.patienceID = Child.id;
        game.screenName = screenName;
        
        StartCoroutine(Upload());
    }
    public void Okay()
    {
        emotionalResponseData = "Okay";
        isButtonClicked = true;

        game = new GameData();
        game.feedBack = emotionalResponseData;
        game.patienceID = Child.id;
        game.screenName = screenName;
       
        StartCoroutine(Upload());
    }
    void Update()
    {
        if(isButtonClicked)
        {
            closingCanvas.SetActive(true);
            timer += Time.deltaTime;
            if (timer >= transitionalEffectDelay)
            {
                SceneManager.LoadScene(nameOfLevelToGoTo);
            }
        }
      
    }
}
