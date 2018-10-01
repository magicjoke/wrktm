using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorkTimeCounter : MonoBehaviour
{

    public bool workStart;

    public string timerText;
    public Text timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (workStart == true)
        {
            timerText += Time.deltaTime;
            //zone.text = timerText;
        }
    }
}
