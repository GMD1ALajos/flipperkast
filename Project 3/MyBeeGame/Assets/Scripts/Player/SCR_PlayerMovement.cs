using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_PlayerMovement : MonoBehaviour {

    public float playerSpeed;

	void Start ()
    {
        Cursor.visible = false;
	}

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            Cursor.visible = true;
        }
    }
	
	void FixedUpdate ()
    {
        float moveH = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        transform.Translate(moveH, 0, 0);
	}
}
