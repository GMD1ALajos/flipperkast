using UnityEngine;
using System.Collections;

public class LeftFlipperControl : MonoBehaviour
{

    public float amount = 500000f;

    void Start()
    {
        //de snelheid(velocity) word hier bepaald.
        GetComponent<Rigidbody>().maxAngularVelocity = 20;
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        //de knop "linkersmuisknop" word toegewezen aan de hinge.
        if (Input.GetButton("Fire1"))
        {
            GetComponent<Rigidbody>().AddTorque(transform.forward * -amount, ForceMode.Impulse);

        }

        else
        {
            GetComponent<Rigidbody>().AddTorque(transform.forward * amount, ForceMode.Impulse);
        }
	}
}
