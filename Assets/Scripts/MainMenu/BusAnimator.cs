﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusAnimator : MonoBehaviour {

	// Use this for initialization
	void Start () {
        iTween.MoveBy(gameObject, iTween.Hash("x", 330, "easeType", "linear", "loopType", "loop", "time", 20));
    }
}
