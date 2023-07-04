using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public float TimeValue = 1800;
    public TextMeshProUGUI Timetext;

    // Update is called once per frame
    void Update()
    {
        if(TimeValue>0){
        TimeValue-= Time.deltaTime;
        displayTime(TimeValue);
        }
        else{
            SceneManager.LoadScene("GameOver");
        }
    }

    void displayTime(float Timetodisplay){
        if(Timetodisplay<0){
            Timetodisplay = 0;
        }
        float minutes = Mathf.FloorToInt(Timetodisplay/60);
        float seconds = Mathf.FloorToInt(Timetodisplay%60);
        Timetext.text = string.Format("{0:00}:{1:00}",minutes,seconds);
    }
}
