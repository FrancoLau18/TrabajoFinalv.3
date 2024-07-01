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
    public PlayerControl player;
    private void Start()
    {
       
        DecreaseLife(player.Life);
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
