using UnityEngine;
using System.Collections;

public class Timelaunchpower : MonoBehaviour
{
    public float timecounter;
    public string maxpower;
    public Vector3 force;
    public Rigidbody player;
    public bool readytolaunch;

    // Update is called once per frame
    void Update()
    {
        if (readytolaunch == true
            &&
            Input.GetButtonUp("Jump"))
        {
            player.AddForce(force * timecounter);
            timecounter = 0;

        }
        if (Input.GetButtonUp("Jump"))
        {
            readytolaunch = false;
        }
        if (Input.GetButton("Jump"))
            Tim();
        if (timecounter >= 3)
        {
            timecounter = 3;
            print(maxpower);
        }
    }
    public void Tim()
    {
        timecounter = timecounter + (1 * Time.deltaTime);
    }
    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "launcher")
        {
            readytolaunch = true;

        }
    }
}