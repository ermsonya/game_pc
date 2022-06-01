using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //������ � ������������
using UnityEngine.SceneManagement; //������ �� �������
using UnityEngine.Audio; //������ � �����
public class escape : MonoBehaviour
{
    
    public bool isOpened = false; //������� �� ����
    public GameObject canvas;
    public AudioMixer am; //��������� ���������
  

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
        SceneManager.LoadScene("Menu"); //������� �� ����� � ��������� Menu
    }
    public void QuitGame()
    {
        Application.Quit(); //�������� ����. � ���������, �������, ��� ������� �� �����, ������� ��� �������� ����� ������������ Debug.Log();
    }
void Update()
    {
        

        if (Input.GetKey(KeyCode.Escape))
        {Time.timeScale = 0;
            ShowHideMenu();
        }
    }
}

