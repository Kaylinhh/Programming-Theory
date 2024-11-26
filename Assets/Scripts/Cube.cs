using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Cube : Shape
{
    //POLYMORPHISM
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
