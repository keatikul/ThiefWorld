using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static Timer instantiateTimer;
    public float timeValue;
    public Text timeText;

    public GameObject[] canvas;

    private void Start()
    {
        Makesingleton();
    }
    void Makesingleton()
    {
        if (instantiateTimer == null)
        {
            instantiateTimer = this;
        }
    }
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }
        DisplayTime(timeValue);
        if (timeValue == 0)
        {
            Debug.Log("Time up");
            for (int i = 0; i < canvas.Length; i++)
            {
                if (canvas[i].activeSelf == true)
                {
                    canvas[i].SetActive(false);
                    //timeValue = 7f;
                }
            }
            
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float secounds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, secounds);
    }
}