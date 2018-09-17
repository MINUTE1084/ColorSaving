using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : ColorBar
{
    public Player Player_;
    public Text MaxTime, RemainTime;
    public float timerTime = 10;
    float time_;
    string[] AreaList = new string[8] { "Blue", "Black", "Green", "Orange", "Purple", "Red", "White", "Yellow"};
    string CurrentArea, PrevArea;

    void Start () {
        Reset_();
    }
	
	void Update () {
		if (time_ > 0)
        {
            time_ -= Time.deltaTime;
            ChangingColorBar(time_ / timerTime, CurrentArea);
            RemainTime.text = time_.ToString("F");
        }

        else
        {
            if (Player_.gameObject.activeSelf)
            {
                if (!Player_.IsRightArea(CurrentArea)) return;
                PrevArea = CurrentArea;
                time_ = timerTime - (Player_.GetScore() / 5);
                do CurrentArea = AreaList[Random.Range(0, AreaList.Length)];
                    while (PrevArea == CurrentArea);
                MaxTime.text = time_.ToString();
            }
        }
	}

    public void Reset_()
    {
        Player_.Reset_();
        time_ = timerTime;
        MaxTime.text = time_.ToString();
        RemainTime.text = time_.ToString();
        CurrentArea = AreaList[Random.Range(0, AreaList.Length)];
    }
}
