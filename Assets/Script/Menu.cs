using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private void Start()
    {
        
    }
    public void ButtonPressed()
    {
        SceneManager.LoadScene("SampleScene");

    }
    public void Exit()
    {
        Application.Quit();
    }
}
