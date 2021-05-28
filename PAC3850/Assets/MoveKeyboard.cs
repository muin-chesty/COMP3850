// <div>Icons made by <a href="https://www.flaticon.com/authors/pixel-perfect" title="Pixel perfect">Pixel perfect</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a></div>
using UnityEngine;

public class MoveKeyboard : MonoBehaviour
{

    public float growOffset = 0.2f;
    public float moveOffset = 10f;

    public RectTransform keyboard;
    public void Grow()
    {
        keyboard.localScale = new Vector3(keyboard.localScale.x + growOffset, keyboard.localScale.y + growOffset, keyboard.localScale.z);
    }
    public void Shrink()
    {
        keyboard.localScale = new Vector3(keyboard.localScale.x - growOffset, keyboard.localScale.y - growOffset, keyboard.localScale.z);
    }
    public void MoveRight()
    {
        keyboard.position = new Vector3(keyboard.position.x + moveOffset, keyboard.position.y, keyboard.position.z);
    }

    public void MoveLeft()
    {
        keyboard.position = new Vector3(keyboard.position.x - moveOffset, keyboard.position.y, keyboard.position.z);
    }

    public void MoveUp()
    {
        keyboard.position = new Vector3(keyboard.position.x, keyboard.position.y + moveOffset, keyboard.position.z);
    }

    public void MoveDown()
    {
        keyboard.position = new Vector3(keyboard.position.x, keyboard.position.y - moveOffset, keyboard.position.z);
    }
}
