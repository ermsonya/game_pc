using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Работа с интерфейсами
using UnityEngine.SceneManagement; //Работа со сценами
using UnityEngine.Audio; //Работа с аудио
public class escape : MonoBehaviour
{
    
    public bool isOpened = false; //Открыто ли меню
    public GameObject canvas;
    public AudioMixer am; //Регулятор громкости
  

    public void ShowHideMenu()
    {
        
        canvas.SetActive(true);
    }
    public void AudioVolume(float sliderValue)
    {
        am.SetFloat("masterVolume", sliderValue);
    }

    public void continueee()
    {
        Time.timeScale = 1;
    }
    public void GoToMain()
    {
        SceneManager.LoadScene("Menu"); //Переход на сцену с названием Menu
    }
    public void QuitGame()
    {
        Application.Quit(); //Закрытие игры. В редакторе, кончено, она закрыта не будет, поэтому для проверки можно использовать Debug.Log();
    }
void Update()
    {
        

        if (Input.GetKey(KeyCode.Escape))
        {Time.timeScale = 0;
            ShowHideMenu();
        }
    }
}

