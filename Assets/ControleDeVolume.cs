using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class ControleDeVolume : MonoBehaviour
{
    [SerializeField]
    private AudioMixer audioMixer;
    [SerializeField]
    private String NomeParametroExposed;

    private Slider volumeSlider;

    private void Start()
    {
        volumeSlider = GetComponent<Slider>();
        volumeSlider.value = PlayerPrefs.GetFloat(NomeParametroExposed, 0);
    }
    public void AlterarVolume()
    {
        audioMixer.SetFloat(NomeParametroExposed, volumeSlider.value);
        PlayerPrefs.SetFloat(NomeParametroExposed, volumeSlider.value);
    }
}   
