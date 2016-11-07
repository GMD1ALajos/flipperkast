using UnityEngine;
using System.Collections;

public class Deathzone : MonoBehaviour

{
    //public Vector3 startplace;
    public bool touch;


    void OnCollisionEnter(Collision collision)
    {
        touch = true; //Als de er een collision(aanraking) is gaat de bool op waar > vervolgt in script Respawn.
        //GameObject.("Pinball").GetComponent<Transform>().position = startplace;

    }
}
