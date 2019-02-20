using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    public int Timer_Way;
    private float Way;
	
	void Update () {
        Way += 1 * Time.deltaTime;
        if (Way > 1)
        {
            Timer_Way += 1;
            Way = 0;
        }

	}
}
