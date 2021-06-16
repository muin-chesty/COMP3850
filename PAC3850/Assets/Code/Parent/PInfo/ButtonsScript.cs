using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    private const string PARENT_MENU = "Paths";
    private const int LOWEST_POSSIBLE_ID_LENGTH = 7;
    private const int ASCII_OF_ZERO = 48;
    private const int ASCII_OF_NINE = 57;


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
    private TouchScreenKeyboard key;

    private void Start()
    {
        anim = firstNameInput.transform.GetComponent<Animator>();
        idAnimator = idInput.transform.GetComponent<Animator>();
        outroGameObject.SetActive(false);
       
    }
    public void Keyboard()
    {
        key = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
        key.active = true;
       
    }
   
    private void Update()
    {
       if(key != null && key.active)
        {
            Debug.Log(key.active);
        }
       
        if(isLevelComplete)
        {
            timerForLevelTranisition += Time.deltaTime;
            Parent.name = firstName.text;
            Parent.id = id.text;
            if(timerForLevelTranisition >= transitionPauseInSeconds)
            {
                timerForLevelTranisition = 0.0f;
                isLevelComplete = false;
                LoadLevel(PARENT_MENU);
            }
        }
        // RESETS BACK TO FALSE SO ANIMATION CAN BE TRIGGERED AGAIN
        if (anim.GetBool("isEmpty") == true)
        {
            timer += Time.deltaTime;
            if(timer >= waitForNSeconds)
            {
                timer = 0.0f;
                anim.SetBool("isEmpty", false);
            }
        }
        // RESETS BACK TO FALSE SO ANIMATION CAN BE TRIGGERED AGAIN
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

    // VALIDATES ID INPUT: LENGTH >=7 AND ALL NUMBERS
    private bool IsValidInput()
    {
        char[] tempId = id.text.ToCharArray();
        bool isValid = true;
        for (int i = 0; i < tempId.Length && isValid; i++)
        {
            if (tempId[i] < ASCII_OF_ZERO || tempId[i] > ASCII_OF_NINE)
            {
                isValid = false;
            }
        }
        return isValid;
    }
    // THIS FUNCTION SHOULD BE CALLED FROM THE PLAY BUTTON ON PARENT INFO LEVEL
    public void ParentInfoButton()
    {

        if(firstName.text.Length > 0 && id.text.Length >= LOWEST_POSSIBLE_ID_LENGTH && IsValidInput())
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

            if (id.text.Length <= 6 || ( IsValidInput() == false))
            {

                idAnimator.SetBool("isEmpty", true);
            }
        }
        
    }

}
