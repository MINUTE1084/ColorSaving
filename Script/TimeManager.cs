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
            if (Player_.gameObject.activeSelf) // 플레이어가 살아 있다면
            {
                if (!Player_.IsRightArea(CurrentArea)) return; // 플레이어의 탈락 여부 결정
                PrevArea = CurrentArea;
                time_ = timerTime - (Player_.GetScore() / 5); // 점수를 얻을 때 마다 시간이 줄어듬
                do CurrentArea = AreaList[Random.Range(0, AreaList.Length)];
                    while (PrevArea == CurrentArea); // 이전 필드와 겹치지 않도록 랜덤 설정
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
