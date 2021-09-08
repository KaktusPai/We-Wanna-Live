using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class managerscript : MonoBehaviour
{
    public static int rightNumbers;
    public static int wrongNumbers;
    public static float time;
    public int rn;
    public int wn;
    public bool win = false;

    public static int calls = 20;
    public static float gameTime = 400;
    public Text callsText;
    public Text timerText;
    public Slider timeBar;

    void Start()
    {
        
    }
    void Update()
    {
        time = gameTime - Time.time;

        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);

        string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);
        timeBar.value = time;
        timeBar.maxValue = gameTime;
        timerText.text = textTime;

        callsText.text = calls.ToString() + " calls left";

        //wincondition
        if (rightNumbers == -17)
        {
            SceneManager.LoadScene(1);
        }

        if (time <= 0)
        {
            SceneManager.LoadScene(2);
        }

        rn = rightNumbers;
        wn = wrongNumbers;
    }
}
