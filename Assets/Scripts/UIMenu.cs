using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenu : MonoBehaviour
{
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
}
