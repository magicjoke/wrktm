using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

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

    public Text zone3;
    public float lapTime;
    public string lapTimerText;

    //----DAYSTAMPS --//

    public Text stop1;
    public Text stop2;
    public Text stop3;
    public Text stop4;
    public Text stop5;
    public Text stop6;
    public Text stop7;

    public bool textStop1;
    public bool textStop2;
    public bool textStop3;
    public bool textStop4;
    public bool textStop5;
    public bool textStop6;
    public bool textStop7;

    public string sumDayString;
    public Text sumDay;

    public int d;
    //--ENDDAYSTAMPS --//



    public bool isWorking = false;

    public bool addMin;
    public bool add30Min;
    public bool add60Min;


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
                int hours = ((intTime / 3600) % 24);
                int minutes = ((intTime / 60) % 60);
                int seconds = (intTime % 60);
                float fraction = time * 1000;
                fraction = (fraction % 1000);
                string timerText = string.Format("{0:00}:{1:00}:{2:00}:{3:000}", hours, minutes, seconds, fraction);
                return timerText;
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            lapTime = startTime + Time.time;
            //lapTime = lapTimerText;
            int intTime = (int)lapTime;
            int hours = ((intTime / 3600) % 24);
            int minutes = ((intTime / 60) % 60);
            int seconds = (intTime % 60);
            lapTimerText = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
            zone3.text = lapTimerText;

            startTime -= timeTaken;

            if (stop1.text == "Stop1")
            {
                stop1.text = lapTimerText;
            }
            else if (stop2.text == "Stop2")
            {
                stop2.text = lapTimerText;
            }
            else if (stop3.text == "Stop3")
            {
                stop3.text = lapTimerText;
            }
            else if (stop4.text == "Stop4")
            {
                stop4.text = lapTimerText;
            }
            else if (stop5.text == "Stop5")
            {
                stop5.text = lapTimerText;
            }
            else if (stop6.text == "Stop6")
            {
                stop6.text = lapTimerText;
            }
            else if (stop7.text == "Stop7")
            {
                stop7.text = lapTimerText;
            }
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            int a = Convert.ToInt32(stop1.text);
            int b = Convert.ToInt32(stop2.text);

            int c = a + b;

            d = c;
            //sumDayString = c.ToString();
            //sumDayString = sumDay.text;
            //stop1 + stop2 = sumDaytext;
        }


        if (addMin == true)
        {
            startTime += 60;
            addMin = false;
        }

        if (add30Min == true)
        {
            startTime += 1800;
            add30Min = false;
        }
        if (add60Min == true)
        {
            startTime += 3600;
            add60Min = false;
        }
    }

    public void AddOneMinute()
    {
        addMin = !addMin;
    }
    public void Add30Minute()
    {
        add30Min = !addMin;
    }
    public void Add60Minute()
    {
        add60Min = !addMin;
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
