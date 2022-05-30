using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{

    public static ScoreManager Instance;
    public Text gameoverscore;
    public GameObject inputManager;
    public Text score;
    public int Score;
    public Text bintext;
    public int binscore;
    void Start()
    {
        Score = 0;
        binscore = 0;
    }
    private void Awake()
    {
        Instance = this;
    }
    public void AddMainScore(int score)
    {
        Score += score;
        this.score.text = Score.ToString();
        gameoverscore.text = Score.ToString();

    }
    public void SubtractMainScore(int score)
    {
        Score -= score;
        this.score.text = Score.ToString();
    }
    public void AddBinCount()
    {
        binscore++;
        bintext.text = binscore.ToString();
    }
}