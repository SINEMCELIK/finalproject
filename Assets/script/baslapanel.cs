using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class baslapanel : MonoBehaviour
{
   
    public void ExitButton()
    {
        Application.Quit();
    }
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }
    public void FirstScene()
    {
        SceneManager.LoadScene(0);
    }
}
