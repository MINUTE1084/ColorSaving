using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    float y = 0;
	// Update is called once per frame
	void Update () {
        
        transform.rotation = Quaternion.Euler(0, y +=  Time.deltaTime * 120, 0);

    }


}