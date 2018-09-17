﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsometricCamera : MonoBehaviour {

    [SerializeField]
    float offsetY = 4f;
    public GameObject player;
	
	void Update () {
        transform.position =new Vector3(
            player.transform.position.x,
            player.transform.position.y + offsetY,
            player.transform.position.z);
	}
}
