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
        if (readytolaunch == true       //de bal krijgt alleen een addforce (kracht) als readytolaunch true(aan) is en als er op de spatie knop gedrukt wordt
            &&
            Input.GetButtonUp("Jump"))  //de knop Jump oftewel spatie moet ingedrukt worden
        {
            player.AddForce(force * timecounter); //de bal, of speler, krijgt een force die nog eens maal de tijd is.
            timecounter = 0;

        }
        if (Input.GetButtonUp("Jump"))
        {
            readytolaunch = false;
        }
        if (Input.GetButton("Jump"))
            Tim();
        if (timecounter >= 3) //de tijd loopt op tot 3 zodra de spatie in gedrukt word, en dit word nog eens vermenigvuldigd bij de bestaande force
        {
            timecounter = 3; //de tijd loopt maximaal tot 3 op
            print(maxpower);
        }
    }
    public void Tim()
    {
        timecounter = timecounter + (1 * Time.deltaTime); //de tijd word bij elkaar opgeteld
    }
    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "launcher")
        {
            readytolaunch = true; //deze waarde staat op true (waar) alleen als de bal het object met de tag "launcher" aanraakt

        }
    }
}