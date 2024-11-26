using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    public override void DisplayText()
    {
        if (messageText != null)
        {
            messageText.text = $"I'm {ShapeName}, the cube!";
        }
        else
        {
            Debug.Log("TextMeshPro not assigned");
        }
    }
}
