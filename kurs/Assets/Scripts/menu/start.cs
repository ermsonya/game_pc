using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class start : MonoBehaviour
{
   
    public void PlayPressed()
    {
        
        SceneManager.LoadScene("first scene");
Time.timeScale = 1;
    }
    public void ExitPressed()
    {
        Application.Quit();
    }
}
