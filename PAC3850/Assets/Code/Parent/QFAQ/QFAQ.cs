using UnityEngine.SceneManagement;
using UnityEngine;

public class QFAQ : MonoBehaviour
{
    public void LoadFAQ()
    {
        SceneManager.LoadScene("ChildInfo");
    }

    public void LoadAsk()
    {
        SceneManager.LoadScene("ParentInfo");
    }
}
