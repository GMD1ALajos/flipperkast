using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Respawn : MonoBehaviour {
    public Vector3 startplace;
    public int pinballs;
    public Text text;

    // Use this for initialization
    void Start() {

        pinballs = 3;
        //De speler heeft 3 levens (pinballs).
    }

    // Update is called once per frame.
    void Update()
    {

        if (GameObject.Find("Deathzone").GetComponent<Deathzone>().touch == true) {
            transform.position = startplace; //pinball word naar een "startplace" verplaatst zodra hij de collider "Deathzone" aanraakt.
            pinballs = pinballs - 1; //bij aanraking van "Deathzone" verliest de speler 1 leven/bal.
            GameObject.Find("Deathzone").GetComponent<Deathzone>().touch = false;
            //Zodra de bal weer terug is, is de aanraking met "Deathzone" weer uit.
        }

        text.text = pinballs.ToString();
        //De levens worden naar de UI geprint.
        if (GameObject.Find("Extralife").GetComponent<Gainpin>().colbox == true) {
            pinballs = pinballs + 1;
            GameObject.Find("Extralife").GetComponent<Gainpin>().colbox = false;
            //Zodra de waarde van colbox waar is krijgt de speler er een leven/pinball bij. Deze gaat vervolgens uit zodat hij niet blijft oplopen.
        }
        if (pinballs == 0) //Zodra de pinballs op 0 staan gebeurt het volgende.
        {
            GameObject.Find("Mainmenu").GetComponent<Menuscript>().Playmenu();
            pinballs = 3;
            //Als de pinballs op 0 staan, verandert het spel naar de "Gameover" UI.
            //Zodra de speler hier zit worden de pinballs weer gereset.
        }

    }

}
