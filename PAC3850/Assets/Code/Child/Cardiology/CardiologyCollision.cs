using UnityEngine;

public class CardiologyCollision : MonoBehaviour
{
    public FeelCardiology fc;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Stethoscope")
        {
            if (gameObject.name == "Chest")
            {
                fc.ChestChecked();
            }

            fc.ChestCollisionCompleted();
            collision.gameObject.transform.position = FeelCardiology.STETHOSCOPE_INIT_POS;
        }

        if (collision.gameObject.name == "Hand" && gameObject.name != "Chest")
        {
            if(gameObject.name == "Fingers")
            {
                fc.HandChecked();
            }
            if (gameObject.name == "Feet")
            {
                fc.FeetChecked();
            }
            if (gameObject.name == "Tummy")
            {
                fc.TummyChecked();
            }

            fc.FeelCollisionCompleted();
            collision.gameObject.transform.position = FeelCardiology.HAND_INIT_POS;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
