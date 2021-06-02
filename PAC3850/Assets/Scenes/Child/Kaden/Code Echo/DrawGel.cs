using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGel : MonoBehaviour
{

    public Camera m_camera;
    public GameObject gel;

    LineRenderer currentLine;
    Vector2 lastPos;

    private void Update()
    {
        Draw();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /*
    void Update()
    {
        
    }
    */

    void Draw()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            CreateBrush();
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector2 mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
            if(mousePos != lastPos)
            {
                AddAPoint(mousePos);
                lastPos = mousePos;
            }
        }
        else
        {
            currentLine = null;
        }
    }

    void CreateBrush()
    {
        GameObject brushInstance = Instantiate(gel);
        currentLine = brushInstance.GetComponent<LineRenderer>();

        Vector2 mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);

        currentLine.SetPosition(0, mousePos);
        currentLine.SetPosition(1, mousePos);
    }

    void AddAPoint(Vector2 pointPos)
    {
        currentLine.positionCount++;
        int positionIndex = currentLine.positionCount - 1;
        currentLine.SetPosition(positionIndex, pointPos);
    }
}
