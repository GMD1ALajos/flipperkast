using UnityEngine;
using System.Collections;

public class WallBumpers : MonoBehaviour
{
    //variabellen
    public Vector3 direction;
    public Rigidbody ball;

    public void OnCollisionEnter(Collision collision)
    {
        //De directie word bepaald door de aanraking
        direction = collision.contacts[0].normal;
        //De ball krijgt een bepaalde kracht toegewezen
        ball.AddForce(direction * -35);
    }

}
