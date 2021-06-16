
using UnityEngine;

public class MoveTowardsBagpack : MonoBehaviour
{


    public AudioSource audioSource;
    public AudioClip sfx;
    public float sfxVolume;
    public GameObject handIcon;

    [Header("Drag Collect VFX")]
    [Space]
    public GameObject VFXCollect;

    [Header("Backpack items in the panel")]
    [Space]
    public GameObject lunchBox;
    public GameObject water;
    public GameObject activityBag;
    public GameObject meficare;



    private void OnMouseDown()
    {
        audioSource.PlayOneShot(sfx, sfxVolume);
        Instantiate(VFXCollect, transform);
        if (gameObject.name == "Water")
        {
          
            if(!water.activeSelf)
            {
                GateKeeper.count++;
                water.SetActive(true);
            }
           
            
        }
        if (gameObject.name == "Lunchbox")
        {
            if(!lunchBox.activeSelf)
            {
                GateKeeper.count++;
                lunchBox.SetActive(true);

            }

        }
        if (gameObject.name == "Activities")
        {
            if(!activityBag.activeSelf)
            {
                GateKeeper.count++;
                activityBag.SetActive(true);
            }
            
          
        }

        if (gameObject.name == "meficare")
        {

            if (!meficare.activeSelf)
            {
                GateKeeper.count++;
                meficare.SetActive(true);
            }


        }

    }

    private void Update()
    {
       /* if(isClicked)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPos, Time.deltaTime * speed);
        }*/
    }
}
