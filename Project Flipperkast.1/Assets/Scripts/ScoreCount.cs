using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScoreCount : MonoBehaviour
{
    public int score;
    public int lowscore;

    public void OnCollisionEnter(Collision collision) //de volgende code werkt alleen met een collision
    {
        score = score + lowscore;
        //score word berekend.
    }
}