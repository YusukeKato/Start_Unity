// Copyright 2018 Yusuke Kato All Rights Reserved. 
// License : MIT

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    float point = 0.01f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 NewPosition = transform.position;
        if(NewPosition.x > 1.0f)
        {
            point = -0.01f;
        }
        else if(NewPosition.x < -1.0f)
        {
            point = 0.01f;
        }
        NewPosition.x += point;
        transform.position = NewPosition;
	}
}
