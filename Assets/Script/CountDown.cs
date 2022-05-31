using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class CountDown : MonoBehaviour
{
    public List<GameObject> _obj;
    public Canvas HomeScreen;
    public Canvas OverScreen;
    public static CountDown instance;
    private void Awake()
    {
        instance = this;
    }
    public int objremain;
    public bool TimeOn = false;
    public float TimeRemain;
    public Text currenttimetext;
    private void Start()
    {
        TimeOn = true;
        objremain = 15;
    }
    
    private void Update()
    {
        if (objremain == 0)
            {
                OverScreen.gameObject.SetActive(true);
                HomeScreen.gameObject.SetActive(false);
            }
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
    }   
}