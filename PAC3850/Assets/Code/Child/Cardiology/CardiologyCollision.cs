using UnityEngine;

public class CardiologyCollision : MonoBehaviour
{
    public FeelCardiology fc;
    public GameObject vfx;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Stethoscope")
        {
            if (gameObject.name == "Chest")
            {
                fc.ChestChecked();
            }
            Instantiate(vfx, transform).SetActive(true);
            collision.gameObject.SetActive(false);
            fc.ChestCollisionCompleted();
           // collision.gameObject.transform.position = FeelCardiology.STETHOSCOPE_INIT_POS;
        }

        if(collision.gameObject.name == "Hand" && gameObject.name != "Chest")
        {
            Instantiate(vfx, transform).SetActive(true);
            collision.gameObject.SetActive(false);
            if (gameObject.name == "Fingers")
            {
                fc.HandChecked();
            }
        }
        if (collision.gameObject.name == "Hand Two" && gameObject.name != "Chest")
        {
            Instantiate(vfx, transform).SetActive(true);
            collision.gameObject.SetActive(false);
            if (gameObject.name == "Feet")
            {
                fc.FeetChecked();
            }
        }

 

        if (collision.gameObject.name == "Hand Three" && gameObject.name != "Chest")
        {
            Instantiate(vfx, transform).SetActive(true);
            collision.gameObject.SetActive(false);
            if (gameObject.name == "Tummy")
            {
                fc.TummyChecked();
            }

        //    fc.FeelCollisionCompleted();
           
           // collision.gameObject.transform.position = FeelCardiology.HAND_INIT_POS;
        }
    }
}
