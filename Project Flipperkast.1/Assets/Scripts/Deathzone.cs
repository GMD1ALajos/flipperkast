using UnityEngine;
using System.Collections;

public class Deathzone : MonoBehaviour

{
    //public Vector3 startplace;
    public bool touch;


    void OnCollisionEnter(Collision collision)
    {
        touch = true;
        //GameObject.("Pinball").GetComponent<Transform>().position = startplace;

    }
}
