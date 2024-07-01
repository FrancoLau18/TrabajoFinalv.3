using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public Text textTime;
    public float timer;
    public int timer_int;
    void Start()
    {
        timer = 60;
    }
    void Update()
    {
        timer = timer - Time.deltaTime;
        timer_int = (int)timer;
        textTime.text  = "" + timer_int;
        if (timer_int == 0)
        {
            SceneManager.LoadScene("Tienda");
        }
    }

}
