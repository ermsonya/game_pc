using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio; //������ � �����
using UnityEngine.UI; //������ � ������������
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
