using UnityEngine;
using System.Collections;

public class ForcePush : MonoBehaviour {

    public Vector3 direction;
    public Rigidbody ball;
    public int force = -100;

    public void OnCollisionEnter(Collision collision)
    {
        direction = collision.contacts[0].normal;
        ball.AddForce(direction * -1000);
    }
    public void Update() {


    }
}
