using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class LineScript : MonoBehaviour
{
    private LineRenderer line;
    private Vector3 mousePos;
    public Material material;
    private int currLines = 0;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (line == null)
            {
                createLine();
            }
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 1;
            line.SetPosition(0, mousePos);
            line.SetPosition(1, mousePos);
        }
        else if (Input.GetMouseButtonUp(0) && line)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 1;
            line.SetPosition(1, mousePos);
            line = null;
            currLines++;
        }
        else if (Input.GetMouseButton(0) && line)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 1;
            line.SetPosition(1, mousePos);
        }

    }
    void createLine()
    {
        line = new GameObject("Line" + currLines).AddComponent<LineRenderer>();
        line.material = material;
        line.positionCount = 2;
        line.startWidth = 1.5f;
        line.endWidth = 1.5f;
        line.useWorldSpace = true;
        line.numCapVertices = 50;
    }
}