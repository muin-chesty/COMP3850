using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyKeyboard : MonoBehaviour
{
    public List<InputField> inputFields;
    private InputField focusedField;
    public GameObject keyboard;

    
    private string userText;
    private bool isTouchDown = false;
    private float timer = 0.0f;
    private float delay = 0.3f;
    private bool caps = false;
    void Start()
    {
        keyboard.SetActive(false);
        
    }

    
    private void OnGUI()
    {
        for (int i = 0; i < inputFields.Count; i++)
        {
            if (inputFields[i].isFocused)
            {
                focusedField = inputFields[i];
            }
        }
        if(focusedField != null)
        {
            if(keyboard.activeSelf == false)
            {
                keyboard.SetActive(true);
            }
        }
        
    }
    public void ExitKeyboard()
    {
        keyboard.SetActive(false);
        focusedField = null;
    }

    public void One()
    {
        if (focusedField != null)
        {
            focusedField.text += 1;
        }
    }
    public void Two()
    {
        if (focusedField != null)
        {
            focusedField.text += 2;
        }
    }
    public void Three()
    {
        if (focusedField != null)
        {
            focusedField.text += 3;
        }
    }
    public void Four()
    {
        if (focusedField != null)
        {
            focusedField.text += 4;
        }
    }
    public void Five()
    {
        if (focusedField != null)
        {
            focusedField.text += 5;
        }
    }
    public void Six()
    {
        if (focusedField != null)
        {
            focusedField.text += 6;
        }
    }
    public void Seven()
    {
        if (focusedField != null)
        {
            focusedField.text += 7;
        }
    }
    public void Eight()
    {
        if (focusedField != null)
        {
            focusedField.text += 8;
        }
    }
    public void Nine()
    {
        if (focusedField != null)
        {
            focusedField.text += 9;
        }
    }
    public void Zero()
    {
        if (focusedField != null)
        {
            focusedField.text += 0;
        }
    }
    public void A()
    {
        if (focusedField != null)
        {

            if (caps)
            {
                focusedField.text += 'A';
            }
            else
            {
                focusedField.text += 'a';
            }

        }
    }

    public void B()
    {
        if (focusedField != null)
        {

            if (caps)
            {
                focusedField.text += 'B';
            }
            else
            {
                focusedField.text += 'b';
            }

        }
    }
    public void C()
    {
        if (focusedField != null)
        {

            if (caps)
            {
                focusedField.text += 'C';
            }
            else
            {
                focusedField.text += 'c';
            }

        }
    }
    public void D()
    {
        if (focusedField != null)
        {

            if (caps)
            {
                focusedField.text += 'D';
            }
            else
            {
                focusedField.text += 'd';
            }

        }
    }
    public void E()
    {
        if (focusedField != null)
        {

            if (caps)
            {
                focusedField.text += 'E';
            }
            else
            {
                focusedField.text += 'e';
            }

        }
    }
    public void F()
    {
        if (focusedField != null)
        {

            if (caps)
            {
                focusedField.text += 'F';
            }
            else
            {
                focusedField.text += 'f';
            }

        }
    }
    public void G()
    {
        if (focusedField != null)
        {

            if (caps)
            {
                focusedField.text += 'G';
            }
            else
            {
                focusedField.text += 'g';
            }

        }
    }
    public void H()
    {
        if (focusedField != null)
        {

            if (caps)
            {
                focusedField.text += 'H';
            }
            else
            {
                focusedField.text += 'h';
            }

        }
    }
    public void I()
    {
        if (focusedField != null)
        {

            if (caps)
            {
                focusedField.text += 'I';
            }
            else
            {
                focusedField.text += 'i';
            }

        }
    }
    public void J()
    {
        if (focusedField != null)
        {

            if (caps)
            {
                focusedField.text += 'J';
            }
            else
            {
                focusedField.text += 'j';
            }

        }
    }
    public void K()
    {
        if (focusedField != null)
        {

            if (caps)
            {
                focusedField.text += 'K';
            }
            else
            {
                focusedField.text += 'k';
            }

        }
    }
    public void L()
    {
        if (focusedField != null)
        {

            if (caps)
            {
                focusedField.text += 'L';
            }
            else
            {
                focusedField.text += 'l';
            }

        }
    }
    public void M()
    {
        if (focusedField != null)
        {

            if (caps)
            {
                focusedField.text += 'M';
            }
            else
            {
                focusedField.text += 'm';
            }

        }
    }
    public void N()
    {
        if (focusedField != null)
        {

            if (caps)
            {
                focusedField.text += 'N';
            }
            else
            {
                focusedField.text += 'n';
            }

        }
    }
    public void O()
    {
        if (focusedField != null)
        {

            if (caps)
            {
                focusedField.text += 'O';
            }
            else
            {
                focusedField.text += 'o';
            }

        }
    }
    public void P()
    {
        if (focusedField != null)
        {

            if (caps)
            {
                focusedField.text += 'P';
            }
            else
            {
                focusedField.text += 'p';
            }

        }
    }
    public void Q()
    {
        if (focusedField != null)
        {
            
            if (caps)
            {
                focusedField.text += 'Q';
            }
            else
            {
                focusedField.text += 'q';
            }

        }

    }
    public void R()
    {
        if (focusedField != null)
        {
            
            if (caps)
            {
                focusedField.text += 'R';
            }
            else
            {
                focusedField.text += 'r';
            }

        }

    }
    public void S()
    {
        if (focusedField != null)
        {

            if (caps)
            {
                focusedField.text += 'S';
            }
            else
            {
                focusedField.text += 's';
            }

        }
    }
    public void T()
    {
        if (focusedField != null)
        {

            if (caps)
            {
                focusedField.text += 'T';
            }
            else
            {
                focusedField.text += 't';
            }

        }
    }
    public void U()
    {
        if (focusedField != null)
        {

            if (caps)
            {
                focusedField.text += 'U';
            }
            else
            {
                focusedField.text += 'u';
            }

        }
    }
    public void V()
    {
        if (focusedField != null)
        {

            if (caps)
            {
                focusedField.text += 'V';
            }
            else
            {
                focusedField.text += 'v';
            }

        }
    }
    public void W()
    {
        if(focusedField != null)
        {
            
            if (caps)
            {
                focusedField.text += 'W';
            }
            else
            {
                focusedField.text += 'w';
            }
            
        }
        
    }
    public void X()
    {
        if (focusedField != null)
        {

            if (caps)
            {
                focusedField.text += 'X';
            }
            else
            {
                focusedField.text += 'x';
            }

        }
    }
    public void Y()
    {
        if (focusedField != null)
        {

            if (caps)
            {
                focusedField.text += 'Y';
            }
            else
            {
                focusedField.text += 'y';
            }

        }
    }
    public void hifen()
    {
        if (focusedField != null)
        {

            if (caps)
            {
                focusedField.text += '-';
            }
            else
            {
                focusedField.text += '-';
            }

        }
    }
    public void Z()
    {
        if (focusedField != null)
        {

            if (caps)
            {
                focusedField.text += 'Z';
            }
            else
            {
                focusedField.text += 'z';
            }

        }
    }
    public void Del()
    {
        if(focusedField != null && focusedField.text.Length > 0)
        {
            focusedField.text = focusedField.text.Substring(0, focusedField.text.Length - 1);
        }
        
    }

    public void Caps()
    {
        caps = !caps;
    }

    public void Space()
    {
        if (focusedField != null)
        {
            focusedField.text += " ";
        }
    }
    
    public void MoveCaretRight()
    {
        focusedField.caretPosition = inputFields[0].caretPosition + 1;
    }
    public void MoveCaretLeft()
    {
        focusedField.caretPosition = inputFields[0].caretPosition - 1;
    }
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 2f)
        {
           
            timer = 0f;
        }
       
    }
}
