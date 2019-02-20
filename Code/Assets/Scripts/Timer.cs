using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerWay : MonoBehaviour {
    public Text text;
    public int Timer_Way;
    private float Way;
	
	void Update ()
    {
        text.text = "" + Timer_Way;
        Way += 1 * Time.deltaTime;
        if (Way > 1)
        {
            Timer_Way += 1;
            Way = 0;
        }

	}
}
