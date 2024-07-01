using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManagerControl : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider volumeSlider;
    public Text textLife;
    public int Life;
    private void Start()
    {
        DecreaseLife(10);
    }
    public void UpdateSoundVolume()
    {
        audioSource.volume = volumeSlider.value;
    }
    public void DecreaseLife(int Life)
    {
        this.Life = Life;
        textLife.text  = ":" + this.Life;
    }
}
