using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorkTime : MonoBehaviour
{

    public string timeText;
    public Text zone;


    //public bool workStart;

    //public string timerText;
    //public Text timer;
    public Text zone2;
    public float startTime = 0;
    public float timeTaken;

    public string timerText;

    public bool isWorking = false;

    void Start()
    {

    }
    void Update()
    {
        PlayerPrefs.SetString("date_time", System.DateTime.Now.ToString("HH:mm:ss.fff"));
        //Debug.Log(PlayerPrefs.GetString("date_time"));
        timeText = PlayerPrefs.GetString("date_time");

        zone.text = timeText;

        //PlayerPrefs.SetString("work_time", timerText += Time.deltaTime.ToString("HH:mm:ss"));
        //timerText = PlayerPrefs.GetString("work_time")

        //timer.text = timerText;

        //if (workStart == true)
        //{
        //    timerText += Time.deltaTime;
        //    timer.text = timerText;
        //} 
        if (isWorking == true)
        {
            timeTaken = startTime + Time.time;

            timerText = FormatTime(timeTaken);

            zone2.text = timerText;

            string FormatTime(float time)
            {
                int intTime = (int)time;
                int hours = intTime / 3600;
                int minutes = intTime / 60;
                int seconds = intTime % 60;
                float fraction = time * 1000;
                fraction = (fraction % 1000);
                string timerText = string.Format("{0:00}:{1:00}:{2:00}:{3:000}", hours, minutes, seconds, fraction);
                return timerText;
            }
        }


    }

    //string FormatTime(float time)
    //{
    //    int intTime = (int)time;
    //    int minutes = intTime / 60;
    //    int seconds = intTime % 60;
    //    float fraction = time * 1000;
    //    fraction = (fraction % 1000);
    //    string timerText = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, fraction);
    //    return timerText;
    //}
}
