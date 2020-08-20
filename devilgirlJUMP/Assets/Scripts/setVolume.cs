using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class setVolume : MonoBehaviour
{
    public AudioMixer mixer;
    public void SetVolume(float sliderValue)
    {
        mixer.SetFloat("musicVol", Mathf.Log10(sliderValue) * 20);
    }
}
