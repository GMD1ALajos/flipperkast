using UnityEngine;
using System.Collections;

public class Gainpin : MonoBehaviour {

    public bool colbox;

    void OnTriggerEnter()
    {
        colbox = true;
    }
    //Als de Collider getriggered word gaat de waarde op waar. Dit vervolgt in het Respawn script.
}

