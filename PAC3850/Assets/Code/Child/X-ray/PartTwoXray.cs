using UnityEngine;

public class PartTwoXray : MonoBehaviour
{
    public GameObject apron;
    public GameObject dummyDress;
    public Transform parent;
    public GameObject takeOffButton;

    [SerializeField]
    private float speed = 2f;
    public bool isTakeOffClicked = false;

    public Sprite shirtless;
    public SpriteRenderer player;
    
    public void TakeOff()
    {
        apron.SetActive(true);
        dummyDress.SetActive(true);
        isTakeOffClicked = true;
        takeOffButton.SetActive(false);
        
        //player.sprite = shirtless;
        dummyDress.transform.position = player.transform.position;

    }

    void Start()
    {
        
    }

   
    void Update()
    {
        if(isTakeOffClicked)
        {
            dummyDress.transform.position = Vector2.MoveTowards(dummyDress.transform.position, parent.position, speed * Time.deltaTime);
        }

    }
}
