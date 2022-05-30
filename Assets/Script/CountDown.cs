using UnityEngine;
using UnityEngine.UI;
using System;

public class CountDown : MonoBehaviour
{
    public Canvas HomeScreen;
    public Canvas OverScreen;
    public AudioSource audiosource;
    public AudioClip backgroundclip;
    public AudioClip fillingclip;
    public AudioClip Wrongobjclip;

    public static CountDown instance;
    private void Awake()
    {
        instance = this;
    }
   
    public bool TimeOn = false;
    public float TimeRemain;
    public Text currenttimetext;
    private void Start()
    {
        TimeOn = true;
        audiosource.Play();
    }
    
    private void Update()
    {
        if (TimeOn)
        {
            if (TimeRemain > 0)
            {
                TimeRemain -= Time.deltaTime;
                timerupdate(TimeRemain);
                
            }
            else
            {
                TimeRemain = 0;
                TimeOn = false;
            }
            if(TimeRemain<0.2)
            {
                HomeScreen.gameObject.SetActive(false);
                OverScreen.gameObject.SetActive(true);
            }
        }
          
    }
    void timerupdate(float currenttime)
    {
        currenttime += 1;

        float minute = Mathf.FloorToInt(currenttime / 60);
        float second = Mathf.FloorToInt(currenttime % 60);
        currenttimetext.text = string.Format("{0:00}:{1:00}", minute, second);
        Debug.Log("current" + TimeRemain);
      
    }
    
}