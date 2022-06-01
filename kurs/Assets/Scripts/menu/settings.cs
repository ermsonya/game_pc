using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio; //Работа с аудио
using UnityEngine.UI; //Работа с интерфейсами
public class settings : MonoBehaviour
{
    public AudioMixer am;
    private bool isFullScreen;
    public void FullScreenToggle()
    {
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
    }
    public void AudioVolume(float sliderValue)
    {
        am.SetFloat("masterVolume", sliderValue);
    }
}
