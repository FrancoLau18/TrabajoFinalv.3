using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManagerControl : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider volumeSlider;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateSoundVolume()
    {
        audioSource.volume = volumeSlider.value;
    }
}
