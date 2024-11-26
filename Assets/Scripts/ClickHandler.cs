using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour
{

    private Shape shape;

    void Start()
    {
        shape = GetComponent<Shape>();
    }

    private void OnMouseDown()
    {
        if (shape != null) 
        {
            //ABSTRACTION
            shape.DisplayText();
        }
    }
}
