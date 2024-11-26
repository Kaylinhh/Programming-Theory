using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    public override void DisplayText()
    {
        if (messageText != null)
        {
            messageText.text = $"I'm {ShapeName}, the sphere!";
        }
        else
        {
            Debug.Log("TextMeshPro not assigned");
        }
    }
}
