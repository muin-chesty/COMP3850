using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    private const string PARENT_MENU = "ParentMenu";

    [SerializeField]
    private UnityEngine.UI.InputField firstName;
    [SerializeField]
    private UnityEngine.UI.InputField id;

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
            LoadLevel(PARENT_MENU);
        }
        
    }

}
