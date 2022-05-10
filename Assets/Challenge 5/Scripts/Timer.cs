using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public GameManagerX gameManagerX;

    private TextMeshProUGUI timerText;
    private float time;

    public float maxTime = 60f;


    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if(!gameManagerX.isGameActive)
            return;

        time += Time.deltaTime;
        timerText.text = "Time: " + (maxTime- Mathf.Round(time));

        if (time >= maxTime)
        {
            gameManagerX.GameOver();
            time = 0;
        }

        

    }
}
