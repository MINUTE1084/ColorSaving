using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorBar : MonoBehaviour {
    public GameObject Bar;
    public Text text;

    public void ChangingColorBar(float remainBarLength, string CurrentArea)
    {
        Bar.transform.localScale = new Vector3(remainBarLength, Bar.transform.localScale.y, Bar.transform.localScale.z);

        switch (CurrentArea)
        {
            case "Blue":
                Bar.GetComponent<Image>().color = Color.blue;
                break;
            case "Black":
                Bar.GetComponent<Image>().color = Color.black;
                break;
            case "Green":
                Bar.GetComponent<Image>().color = Color.green;
                break;
            case "Orange":
                Bar.GetComponent<Image>().color = new Color32 (255, 111, 0, 255);
                break;
            case "Purple":
                Bar.GetComponent<Image>().color = new Color32(200, 0, 255, 255);
                break;
            case "White":
                Bar.GetComponent<Image>().color = Color.white;
                break;
            case "Yellow":
                Bar.GetComponent<Image>().color = Color.yellow;
                break;
            case "Red":
                Bar.GetComponent<Image>().color = Color.red;
                break;
        }
        text.text = CurrentArea;
        text.color = new Color32((byte)(255 - Bar.GetComponent<Image>().color.r * 255),
            (byte)(255 - Bar.GetComponent<Image>().color.g * 255),
            (byte)(255 - Bar.GetComponent<Image>().color.b * 255),
            255); // 보색
    }
}
