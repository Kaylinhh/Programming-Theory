using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shape : MonoBehaviour
{
    private string shapeName;
    private Color shapeColor;
    public TextMeshProUGUI messageText;

    //ENCAPSULATION
    public string ShapeName
    {
        get { return shapeName;  }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                shapeName = value;
            }
            else
            {
                Debug.Log("The name of the shape can't be empty!");
                shapeName = "Nameless shape";
            }
        }
    }

    public Color ShapeColor
    {
        get { return shapeColor; }
        set 
        {
            shapeColor = value;

            GetComponent<Renderer>().material.color = shapeColor; //changes the color visually
        }
    }


    public virtual void DisplayText()
    {
        if (messageText != null) 
        {
            messageText.text = $"I'm a shape named {ShapeName}!";
        }
        else 
        {
            Debug.Log("TextMeshPro not assigned");
        }
    }
}
