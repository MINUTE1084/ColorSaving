using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour {
    string currentArea;
    string currentItem;
    int Score = 0;
    public Text scoreText, currentAreaText, currentItemText;

    private void OnCollisionStay(Collision collision)
    {
        currentArea = collision.collider.tag; // 현재 위치 설정
        currentAreaText.text = currentArea;
    }

    public bool IsRightArea(string rightArea)
    {
        if (currentArea != rightArea)
        {
            gameObject.SetActive(false);
            return false;
        }
        
        scoreText.text = (++Score).ToString();
        return true;
    }

    public float GetScore()
    {
        return Score;
    }

    public void Reset_()
    {
        gameObject.SetActive(true);
        gameObject.transform.position = new Vector3(1, 1.5f, 1);
        Score = 0;
        scoreText.text = Score.ToString();
    }
}
