using UnityEngine;
using System.Collections;

public class FlipperController : MonoBehaviour {

    public bool activateFlipper;
    public float timer = 0;
    public GameObject RightFlipper;
    public GameObject LeftFlipper;
    public Rigidbody ball;


	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            activateFlipper = true;
        }
        if (timer > 0.06f)
        {
             activateFlipper = false;
             ball.AddForce(-10, 0, -3);
        }

        if (activateFlipper)
        {
            transform.RotateAround
                (transform.position,
                RightFlipper.transform.forward,
                800 * Time.deltaTime);
            timer = timer + Time.deltaTime;
        }
    }
}
