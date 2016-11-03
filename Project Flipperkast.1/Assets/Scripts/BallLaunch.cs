using UnityEngine;
using System.Collections;

public class BallLaunch : MonoBehaviour {

    public float downtimer;
    public bool buttonpress;
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButton(0))
        {
            downtimer = 0;
            downtimer = downtimer + 100 * Time.deltaTime;
            buttonpress = true;
        }

        else

        {
            buttonpress = false;
        }
        if (downtimer >= 200)
        {
            downtimer = 200;
        }

    }
}
