using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    public int Score { get; set; } = 0;
    public TextMeshProUGUI textUI;
    public TextMeshProUGUI timerUI;

    private float timer = 90.0f;

    static Game instance;
    public static Game Instance { get { return instance; } }

    public enum eState
    { 
        Title,
        StartGame,
        Game,
        GameOver
    }

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        timerUI.text = string.Format("{0}", (int)timer);
    }

    public void AddPoints(int points)
    {
        Score += points;
        textUI.text = string.Format("{0:D4}", Score);
    }

}
