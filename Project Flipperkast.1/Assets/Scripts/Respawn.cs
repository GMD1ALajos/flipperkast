using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Respawn : MonoBehaviour {
    public Vector3 startplace;
    public int pinballs;
    public Text text;

	// Use this for initialization
	void Start () {

        pinballs = 3;
	
	}
	
	// Update is called once per frame
	void Update ()
        {

        if (GameObject.Find("Deathzone").GetComponent<Deathzone>().touch == true) {
            transform.position = startplace;
            pinballs = pinballs - 1;
            GameObject.Find("Deathzone").GetComponent<Deathzone>().touch = false;
        }
        text.text = pinballs.ToString();

        if (pinballs == 0)
        {
            GameObject.Find("Mainmenu").GetComponent<Menuscript>().Playmenu();
            pinballs = 3;
        }
	
	}

}
