﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacija : MonoBehaviour {

	
	void Update () {
        //svaki frame
        transform.Rotate (new Vector3 (15, 30, 45)*Time.deltaTime)
		
	}
}
