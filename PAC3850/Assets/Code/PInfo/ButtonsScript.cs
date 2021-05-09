using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    private const string PARENT_MENU = "ParentMenu";


    [SerializeField]
    private UnityEngine.UI.InputField firstName;
    [SerializeField]
    private UnityEngine.UI.InputField id;
    [SerializeField]
    private GameObject firstNameInput;
    [SerializeField]
    private GameObject idInput;
    [SerializeField]
    private GameObject outroGameObject;



    private Animator anim;          // USED TO CONTROL FIRST NAME INPUT FIELD'S ANIMATION
    private Animator idAnimator;    // USED TO CONTROL ID INPUT FIELD'S ANIMATION
 

    private float timer = 0.0f;     // USED TO RESET FIRST NAME'S BOOL
    private float timerOne = 0.0f;  // USED TO RESET ID'S BOOL
    private float waitForNSeconds = 0.2f;  // USED TO WAIT BEFORE BOOL VALUE RESETS

    private float timerForLevelTranisition = 0.0f;   // TO BE USED TO MEASURE TIME BETWEEN BUTTON CLICK AND LEVEL TRANSITION PAUSE
    private float transitionPauseInSeconds = 1f;     // NUMBER OF SECONDS BEFORE THE NEXT LEVEL LOADS

    private bool isLevelComplete = false;

    private void Start()
    {
        anim = firstNameInput.transform.GetComponent<Animator>();
        idAnimator = idInput.transform.GetComponent<Animator>();
        outroGameObject.SetActive(false);
       
    }
    private void Update()
    {
        if(isLevelComplete)
        {
            timerForLevelTranisition += Time.deltaTime;
            if(timerForLevelTranisition >= transitionPauseInSeconds)
            {
                timerForLevelTranisition = 0.0f;
                isLevelComplete = false;
                LoadLevel(PARENT_MENU);
            }
        }

        if(anim.GetBool("isEmpty") == true)
        {
            timer += Time.deltaTime;
            if(timer >= waitForNSeconds)
            {
                timer = 0.0f;
                anim.SetBool("isEmpty", false);
            }
        }

        if (idAnimator.GetBool("isEmpty") == true)
        {
            timerOne += Time.deltaTime;
            if (timerOne >= waitForNSeconds)
            {
                timerOne = 0.0f;
                idAnimator.SetBool("isEmpty", false);
            }
        }
    }
    private void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
        
    }
    private void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // THIS FUNCTION SHOULD BE CALLED FROM THE PLAY BUTTON ON PARENT INFO LEVEL
    public void ParentInfoButton()
    {
        if(firstName.text.Length > 0 && id.text.Length > 0)
        {
            outroGameObject.SetActive(true);
            isLevelComplete = true;
        }
        else
        {
            if(firstName.text.Length <= 0)
            {
                anim.SetBool("isEmpty", true);
               
            }

            if (id.text.Length <= 0)
            {
                idAnimator.SetBool("isEmpty", true);
                

            }
        }
        
    }

}
