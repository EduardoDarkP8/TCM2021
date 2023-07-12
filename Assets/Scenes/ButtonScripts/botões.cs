using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botões : MonoBehaviour
{
    public void Start() 
    {
        SceneManager.LoadScene(1);
    }
    public void Chapter() 
    {
        SceneManager.LoadScene(5);
    }
    public void exit()
    {
        Application.Quit();
    }
}
