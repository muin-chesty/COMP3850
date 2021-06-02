using UnityEngine;
using UnityEngine.SceneManagement;

public class PartTwoXray : MonoBehaviour
{
    
    public GameObject dummyDress;
    public GameObject takeOffButton;
    public GameObject player;
    public GameObject apronPanel;
    public GameObject startXRayButton;

    [SerializeField]
    private float speed = 2f;
    public bool isTakeOffClicked = false;


    private float timer = 0f;
    public void TakeOff()
    {
        dummyDress.SetActive(true);
        player.SetActive(false);
        isTakeOffClicked = true;
        takeOffButton.SetActive(false);
        
    }

    public void StartXray()
    {
        SceneManager.LoadScene("3-X-Ray");
    }
    private void Update()
    {
        if(isTakeOffClicked)
        {
            timer += Time.deltaTime;
            if(timer >= 2f)
            {
                apronPanel.SetActive(true);
                if(timer >= 10f)
                {
                    startXRayButton.SetActive(true);
                   // 
                }
            }

        }
    }



}
