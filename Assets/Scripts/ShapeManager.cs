using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeManager : MonoBehaviour
{
    [SerializeField]
    private Shape cube;
    [SerializeField]
    private Shape sphere;
    [SerializeField]
    private Shape cylinder;

    private void Start()
    {
        cube.ShapeName = "Bob";
        cube.ShapeColor = Color.red;

        sphere.ShapeName = "Sally";
        sphere.ShapeColor = Color.yellow;

        cylinder.ShapeName = "Matt";
        cylinder.ShapeColor = Color.blue;
    }
}
