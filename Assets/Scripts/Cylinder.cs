using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cylinder : Shape
{
    public override void DisplayText()
    {
        if (messageText != null) 
        {
            messageText.text = $"I'm {ShapeName}, the cylinder!";
        }
        else
        {
            Debug.Log("TextMeshPro not assigned");
        }
    }
}
